using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EmulatorGamesDisplay
{
    public sealed partial class AddGame : Form
    {
        readonly GameBrowser.GameAction _addedGame;
        readonly GameBrowser.GameEdited _editedGame;
        readonly ListViewItem _item;
        readonly string _romDirectory;
        Game _game;

        public AddGame(string pRomDirectory, GameBrowser.GameAction pAddedGame)
        {
            InitializeComponent();
            _game = new Game();
            _romDirectory = pRomDirectory;
            _addedGame = pAddedGame;
        }

        public AddGame(ListViewItem pItem, GameBrowser.GameEdited pEditedGame)
        {
            InitializeComponent();
            _game = (Game)pItem.Tag;
            _item = pItem;
            _editedGame = pEditedGame;
            tbxGameName.Text = _game.Name;
            tbxGameDate.Text = _game.Date;
            tbxGameDescription.Text = _game.Description;
            tbxGameFileName.Text = _game.FileName;

            switch (_game.Platform)
            {
                case "NES":
                case "Nintendo Entertainment System":
                    cmbGamePlatform.SelectedIndex = 0;
                    break;
                case "SNES":
                case "Super Nintendo":
                    cmbGamePlatform.SelectedIndex = 1;
                    break;
                case "N64":
                case "Nintendo 64":
                    cmbGamePlatform.SelectedIndex = 2;
                    break;
                case "GB":
                case "GameBoy":
                    cmbGamePlatform.SelectedIndex = 3;
                    break;
                case "GBC":
                case "GameBoy Color":
                    cmbGamePlatform.SelectedIndex = 4;
                    break;
                case "GBA":
                case "GameBoy Advance":
                    cmbGamePlatform.SelectedIndex = 5;
                    break;
                case "NDS":
                case "Nintendo DS":
                    cmbGamePlatform.SelectedIndex = 6;
                    break;
            }
            cmbGameRating.SelectedIndex = _game.Rating - 1;

            pbxGameIcon.Image = _game.Icon.ResizeImage(64, 64, true);

            btnGenerate.Text = "Save";
            btnReset.Visible = false;
            Text = "Edit Game";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var doReturn = true;
            if (tbxGameName.Text == string.Empty)
                MessageBox.Show("Please specify a name.");
            else if (tbxGameDate.Text == string.Empty)
                MessageBox.Show("Please specify a date.");
            else if (cmbGamePlatform.SelectedItem == null)
                MessageBox.Show("Please specify a platform.");
            else if (tbxGameDescription.Text == string.Empty)
                MessageBox.Show("Please have a description.");
            else if (cmbGameRating.SelectedItem == null)
                MessageBox.Show("Please specify a rating.");
            else if (tbxGameFileName.Text == string.Empty)
                MessageBox.Show("Please specify a filename.");
            else if (_game.Icon == null)
                MessageBox.Show("Please select an icon.");
            else
                doReturn = false;

            if (doReturn)
                return;

            _game.ModifiedOrAdded = true;
            _game.Name = tbxGameName.Text;
            _game.Date = tbxGameDate.Text;
            _game.Platform = (string)cmbGamePlatform.SelectedItem;
            _game.Description = tbxGameDescription.Text;
            _game.Rating = Convert.ToInt32(cmbGameRating.SelectedItem);
            _game.FileName = tbxGameFileName.Text;
            if (_item == null)
                _game.RealFileName = _romDirectory + _game.Name.Replace(":", "") + ".xml";

            var serializer = new XmlSerializer(typeof(Game));
            TextWriter writer = new StreamWriter(_game.RealFileName);
            serializer.Serialize(writer, _game);
            writer.Close();

            if (_item == null)
                _addedGame(_game);
            else
                _editedGame(_item, _game);

            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _game = new Game();
            tbxGameName.Text = "";
            tbxGameDate.Text = "";
            tbxGameDescription.Text = "";
            tbxGameFileName.Text = "";
            cmbGamePlatform.SelectedIndex = -1;
            cmbGameRating.SelectedIndex = -1;
            pbxGameIcon.Image = pbxGameIcon.InitialImage;
        }

        private void pbxGameIcon_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an image...";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Image Files|*.png;*.gif;*.jpg;*.jpeg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            _game.Icon = new SerializableImage(Convert.ToBase64String(File.ReadAllBytes(openFileDialog1.FileName)));
            pbxGameIcon.Image = _game.Icon.ResizeImage(64, 64, true);
        }
    }
}
