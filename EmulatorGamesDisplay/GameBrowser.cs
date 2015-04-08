using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EmulatorGamesDisplay
{
    public partial class GameBrowser : Form
    {
        public delegate void GameAction(Game pGame);
        public delegate void GameEdited(ListViewItem pItem, Game pGame);
        public delegate void OptionsEdited(Config pConfig);
        Config _config;

        public GameBrowser()
        {
            InitializeComponent();

            lvGames.DoubleClick += LvGamesDoubleClick;
            if (File.Exists("config.xml")) //Should we present the user with the options dialog?
            {
                var serializer = new XmlSerializer(typeof(Config));
                TextReader r = new StreamReader("config.xml");
                _config = (Config)serializer.Deserialize(r);
                r.Close();

                //Set the size of the window...
                Width = _config.WindowWidth;
                Height = _config.WindowHeight;
                WindowState = _config.Maximized ? FormWindowState.Maximized : FormWindowState.Normal;

                splitContainer1.Panel2Collapsed = _config.HideSidebar;

                if (_config.RomDirectory.Substring(_config.RomDirectory.Length - 1, 1) != @"\")
                    _config.RomDirectory += @"\";
                imlGameIcons.ImageSize = new Size(_config.IconWidth, _config.IconHeight);

                //Add some handlers...
                FormClosed += Browser_FormClosed;
                contextMenuStrip1.Opening += ContextMenuStrip1Opening;

                //Finally load up the games :D
                LoadUpGames();
            }
            else
            {
                var config = new Config
                                 {
                                     RomDirectory = @"C:\",
                                     DSEmulator = @"C:\Emulators\DSEmulator.exe",
                                     GBAEmulator = @"C:\Emulators\GBAEmulator.exe",
                                     IconHeight = 128,
                                     IconWidth = 128,
                                     N64Emulator = @"C:\Emulators\N64Emulator.exe",
                                     NESEmulator = @"C:\Emulators\NESEmulator.exe",
                                     ResizeWithPlatformIcon = false,
                                     ShowPlatformIcon = false,
                                     SuperNESEmulator = @"C:\Emulators\SNESEmulator.exe"
                                 };

                Hide();
                new Options(config, ConfigEdited).ShowDialog();
            }
        }

        #region Form functions
        void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save config.
            var serializer = new XmlSerializer(typeof(Config));
            TextWriter writer = new StreamWriter("config.xml");
            _config.WindowWidth = Width;
            _config.WindowHeight = Height;
            _config.Maximized = WindowState == FormWindowState.Maximized;
            serializer.Serialize(writer, _config);
            writer.Close();

            //Savin' games.
            serializer = new XmlSerializer(typeof(Game));
            foreach (ListViewItem item in lvGames.Items)
            {
                var game = (Game)item.Tag;
                if (!game.ModifiedOrAdded)
                    continue; //No point in saving it if there were no changes

                writer = new StreamWriter(game.RealFileName);
                serializer.Serialize(writer, game);
                writer.Close();
            }
        }

        void LvGamesDoubleClick(object sender, EventArgs e)
        {
            //Launch the game :)
            var game = (Game)lvGames.SelectedItems[0].Tag;

            var emulator = new Process();
            switch (game.Platform) //Determine the emulator to use...
            {
                case "NES":
                case "Nintendo Entertainment System":
                    emulator.StartInfo.FileName = _config.NESEmulator;
                    break;
                case "SNES":
                case "Super Nintendo":
                    emulator.StartInfo.FileName = _config.SuperNESEmulator;
                    break;
                case "N64":
                case "Nintendo 64":
                    emulator.StartInfo.FileName = _config.N64Emulator;
                    break;
                case "GBA":
                case "GameBoy Advance":
                case "GBC":
                case "GameBoy Color":
                case "GB":
                case "GameBoy":
                    emulator.StartInfo.FileName = _config.GBAEmulator;
                    break;
                case "NDS":
                case "Nintendo DS":
                    emulator.StartInfo.FileName = _config.DSEmulator;
                    break;
            }

            //Check to see if the emulator for the platform exists.
            if (!File.Exists(emulator.StartInfo.FileName))
            {
                MessageBox.Show("The emulator for the " + game.Platform + " does not exist.\nPlease edit the options for the emulator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            if (game.Platform != "Nintendo 64" && game.Platform != "N64")
                emulator.StartInfo.Arguments = "\"" + _config.RomDirectory + game.FileName + "\""; //These emus are good.
            else
                emulator.StartInfo.Arguments = _config.RomDirectory + game.FileName; //Project 64, however, is not...
            emulator.Start();

            //Update the play count, and the label :)
            game.Plays++;
            game.ModifiedOrAdded = true;
            lblGamePlays.Text = game.Plays + (game.Plays == 1 ? " Play" : " Plays");
        }

        private void lvGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGames.SelectedItems.Count != 1) //IE. We just deselected the item
            {
                pbxGameIcon.Visible = false;
                lblGameName.Visible = false;
                lblGameDate.Visible = false;
                lblGamePlatform.Visible = false;
                lblGameRating.Visible = false;
                tbxGameDescription.Visible = false;
                lblGamePlays.Visible = false;
                return;
            }

            var item = lvGames.SelectedItems[0];
            if (!(item.Tag is Game))
                return;
            var game = (Game)item.Tag;

            /*byte[] pictureBytes = System.Convert.FromBase64String(Game.IconBase64);
            Image image = ByteArrayToImage(pictureBytes);
            image = ResizeImage(image, 128, 128, true);

            Bitmap bitmap = new Bitmap(128, 128);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.DrawImage(image, new Point(128 / 2 - image.Width / 2, 128 / 2 - image.Height / 2));
            }
            image = (Image)bitmap;*/

            pbxGameIcon.Image = game.Icon.ResizeImage(128, 128, true);
            lblGameName.Text = game.Name;
            lblGameDate.Text = game.Date;
            lblGamePlatform.Text = game.Platform;
            lblGameRating.Text = game.Rating + (game.Rating == 1 ? " Star" : " Stars");
            tbxGameDescription.Text = game.Description;
            lblGamePlays.Text = game.Plays + (game.Plays == 1 ? " Play" : " Plays");

            pbxGameIcon.Visible = true;
            lblGameName.Visible = true;
            lblGameDate.Visible = true;
            lblGamePlatform.Visible = true;
            lblGameRating.Visible = true;
            tbxGameDescription.Visible = true;
            lblGamePlays.Visible = true;
        }

        private void pbxGameIcon_DoubleClick(object sender, EventArgs e)
        {
            if (lvGames.SelectedItems.Count != 1)
                return;

            new IconViewer(((Game)lvGames.SelectedItems[0].Tag).Icon.Image).ShowDialog();
        }

        #region Context menu items
        void ContextMenuStrip1Opening(object sender, CancelEventArgs e)
        {
            //^We hook it at opening so we can edit it before the person sees it.
            editGameToolStripMenuItem.Visible = lvGames.SelectedItems.Count == 1; //Is there a game selected?
            deleteGameToolStripMenuItem.Visible = lvGames.SelectedItems.Count == 1; //Is there a game selected?
        }

        private void addGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddGame(_config.RomDirectory, GameAdded).ShowDialog();
        }

        private void editGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edit game just uses an edited add game form :)
            new AddGame(lvGames.SelectedItems[0], EditedGame).ShowDialog();
        }

        private void deleteGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Options(_config, ConfigEdited).ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh(); //Self-explanatory.
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 5; i++)
                MessageBox.Show("Z҉̵̞̟̠̖̗̘̙̜̝̞̟̠͇̊̋̌̍̎̏̐̑̒̓̔̊̋̌̍̎̏̐̑̒̚̕̚҉ ̌̍̎̏̐̑̒̓̔̊̋̌̍̎̏̐̑̒̓̔̿̿̿̚̕̕̚̕̚͡A͡L̢GƠ ͠is not goi̶ng ͞t҉o͞ ͘te̛ll͜ ̀y͞ou ̴w̵ha̡t͡ ZALG͏Ó ͢i̢s, for ҉Z̧AL͟GO͘ i͘s̸ not. Z̸A̴LG͝O̕ is ̢ǹot͏ à g͡o͞od҉ t̨hin͠g͘.͜ ̵ ҉Z͜A̢L̕GO͢ ҉is̸ no͟t͏ /̀x/ ̵o̡r ̛S̀A.͠ ͏ ZAL͡GO͘ ͡is͞ n̷o̧t ̢u̕nt̸i̴l̵ the e͟n̵d̀ ͜o̷f ̵days̀.͜ ̷ ̵ ̷He̕ W͞ai͞t͞s͡ ͡Be͜h̵ind T̵he ̕Wal̵l,̴ ͢in a ͡p̀àl҉àcé ̀of͝ ̶t͢o̶rt̸u̸r̶ed͟ gláss͞,͟ ̨served̶ by͡ l͝egio͝ns ̡for̨g҉e̷d f̡rǫm ̧th́e̴ ͠tȩars̸ ̴of͡ ͟th͞e̕ s͞le͞epless ̨de̢a̡d ańd cl̴àd͟ ̵i͜n ar̴mo͘r ̧car̨ved ̶from̕ thę s҉uffe̶r͏in͠g̷ o̧f͘ ̷mo͟t̵h̀e̕r͞s.̸ In͡ ͜his̴ ̨r̷ight͝ ha҉n͡d̨ he̶ holds ͢a͜ ̸dea̕d ̕s̛t́ar̕,̢ ́a̴ǹd͞ in͡ ̧h҉is͢ ̸r͏ight ̨ha̕n͢d he h̛ǫl͏d̵s ͟t̛h̕e ̀Can̸d̛l̴e ̡Wh̛o͟s̶e ͏Ligh͘t͞ ̧I̸s Sh͝a͢d́o͏w.͢ ҉His léf̡t h͢án͢ds͜ àr͝e stain̷ed ͏w̛it̶h͟ t̴he b̡l͟ood̢ ̴of ͠Am Ḑh̀ae͘ga͟r̢. ̵ ̶ ̶ ̵ ͡His ͜six ͜m̧ou͡t̀hs ͏s̶p͏e̡a̴k ͏i͜n͜ ̷di̡f̕f̕erent͜ ̴to̕n҉gu͢ęs͏, ̧a̷ņd͢ ͝t̕hę seven̴t̨h̢ ̴shall s͠in̶g t͞he s͜o̡ng ̷that ̶e̢nd́s̷ ͠th̛e ̸earth̛.̷ ̶ ҉ ̡ ̧ ZALGO ͘ re͜f͠e͢ŕs͜ ͝to͜ th͘e ͡co̷r̛ru̷p͟tion of perféc̸t͜ly ̀i͠nn͏o̡c͘e͏n̢t ̀things̴ ̵and ͘i͡déas,́ ̵s͝uc̶h̶ às̛ c͢omi͢cs̡, s̶t̨ori͘e͘s or ͏m҉e͏me͏s.̕ To ma̡ke͡ ̧th̕e̢m ee̸r͘ie͝ àn҉d͡ \"͠L҉ove͢c͟r͝afti̢a҉n\".̨ ̢ ͢ ҉T̨h̷e̷s̀è ̴ex͞ce̴r̷p̡ts̶ r̢u͢n ţḩe ̶ga͜m҉út̨ ́f͞rom a̵l͘che҉m̕ica̸l do͢c̢umen̕ts̀ f̕r͠om ţhe 1̶60̛0s͞,͠ o͜c͝c̕u͠l͏t͝ ̴texts r̸elating̷ ̨t̸o ̛vàmp͞ire͜s̨, cu͜lt ̷dǫg̀m̧a҉ (̴t͞ráns̡c͘r͡ip̕ts ̵f̕r̡om ͏th͢e͠ ̧vid̶ęo͝ o̵f͡ ̴tha̵t c̸ul̛t that̸ ͞ki̵ll͠ed t̷hem̀sęl͠ves̶ w͜hen ͟t͡he̕ Hale B͝o͞p ćom͜et͜ ̧pa҉s͝s̕e̸d ͝b͝y ͜Ear̴th),͜ ͟s̨e͡gme͟nts̛ o̕f̡ ͝h͘o͝r̵r̛òr͢ st̨ori̡es ͡(̡Br͘a̴hm S̸t͟oke̢r̛'̀s ҉Laiŗ o҉f̴ th̕e Wh̛i̢tȩ ̕Wor͞m),͏ ́a͘n̴d ev҉en thè ҉tria͏l o͠f̨ a̶ ͡m̧an҉ ̢s̶u͢pp͢osed tǫ h̕ave bee̢n a͜ ̢w̡er̴e͝w͡o͟l͞f. ̵A ̶fr͞e͠q̶u͢ent̶ ̛f̛eat̀u͠re̷, ́sav̵e ̀fo̸r t͢he͜ biz͝àr҉re̶ ̷s͜ýḿbols ̢an͝d fo̕r̢ma̕tting,͏ i̢s͏ the ̧ob͏s҉çurati҉o̢n ̴of͞ ͘a̸n̛ytḩi̴ng͡ wit̴h͢ ̢rȩl̷igiou͝s c̵on͢n̴o̸t͢at́i̕ońs;̸ ̸t̛h̢e w̡o͝rd͟s \"̸H̛ea͞v͏e͜n҉\"̧, ̧\"͞re͞li̡g̷io̷n\",̨ ͏\"Go͞ḑ\",̢ e͠t̕c. ͏are̴ oft́ȩn ̷i̸n ͜s̷t̶ri͝k̕e͟throu͘g͠h̛,̷ ańd ̡so͝m͜e͡t͞imes͏ ce̕rta̸in words ͘a͢re̶ ̴e̕ven re̶m͜oved ́f̀r̸o̕m ͜the҉ or̸igina̢ļ ̧t̶exts, ͜n͞ot̛ab͟ĺy \"͜ḩųma̡n̵\"͡ and̨ ̨\"͡gar̶d͡en̴\". ");
        }
        #endregion
        #endregion

        #region Non-form related functions
        private void LoadUpGames()
        {
            //Check to see if the rom directory exists.
            if (!Directory.Exists(_config.RomDirectory))
            {
                MessageBox.Show("The ROM directory specified in config.xml does not exist\nOpen the options dialog and edit the settings.");
                return;
            }

            string[] files = Directory.GetFiles(_config.RomDirectory, "*.xml");

            var s = new XmlSerializer(typeof(Game));
            foreach (var file in files)
            {
                TextReader r = new StreamReader(file);
                var game = (Game)s.Deserialize(r);
                r.Close();
                game.RealFileName = file;

                if (string.IsNullOrEmpty(game.Name) || game.Icon == null) //Some checks so if the user messed with the files
                    continue;

                imlGameIcons.Images.Add(game.Icon.GetPlatformImage(game, _config));
                lvGames.Items.Add(new ListViewItem(game.Name, imlGameIcons.Images.Count - 1) { Tag = game });
            }
            lvGames.Sort();
        }

        private void GameAdded(Game pGame)
        {
            imlGameIcons.Images.Add(pGame.Icon.GetPlatformImage(pGame, _config));
            lvGames.Items.Add(new ListViewItem(pGame.Name, imlGameIcons.Images.Count - 1) { Tag = pGame });
            //Gotta sort the games after we add one :)
            lvGames.Sort();
        }

        private void EditedGame(ListViewItem pItem, Game pGame)
        {
            pItem.Text = pGame.Name;
            Image image = pGame.Icon.GetPlatformImage(pGame, _config);
            imlGameIcons.Images[pItem.ImageIndex] = image;

            //Update the form stuff, etc.
            pbxGameIcon.Image = image;
            lblGameName.Text = pGame.Name;
            lblGameDate.Text = pGame.Date;
            lblGamePlatform.Text = pGame.Platform;
            lblGameRating.Text = pGame.Rating + (pGame.Rating == 1 ? " Star" : " Stars");
            tbxGameDescription.Text = pGame.Description;
            lblGamePlays.Text = pGame.Plays + (pGame.Plays == 1 ? " Play" : " Plays");
        }

        private void ConfigEdited(Config pConfig)
        {
            if (_config == null) //Config.xml not created
            {
                Show();
                _config = pConfig;
            }

            //Save the settings...
            var s = new XmlSerializer(typeof(Config));
            TextWriter w = new StreamWriter("config.xml");
            s.Serialize(w, pConfig);
            w.Close();

            splitContainer1.Panel2Collapsed = _config.HideSidebar;

            //Now refresh...
            Refresh();
        }

        new private void Refresh()
        {
            lvGames.Clear();
            pbxGameIcon.Visible = false;
            lblGameName.Visible = false;
            lblGameDate.Visible = false;
            lblGamePlatform.Visible = false;
            lblGameRating.Visible = false;
            tbxGameDescription.Visible = false;
            lblGamePlays.Visible = false;
            imlGameIcons.ImageSize = new Size(_config.IconWidth, _config.IconHeight); //In case we edited the options.
            LoadUpGames();
        }
        #endregion
    }
}
