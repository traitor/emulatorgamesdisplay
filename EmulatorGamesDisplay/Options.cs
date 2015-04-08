using System;
using System.IO;
using System.Windows.Forms;

namespace EmulatorGamesDisplay
{
    public partial class Options : Form
    {
        readonly Config _config;
        readonly GameBrowser.OptionsEdited _callback;

        public Options(Config pConfig, GameBrowser.OptionsEdited pCallback)
        {
            InitializeComponent();
            _config = pConfig;
            _callback = pCallback;

            //Load settings into fields...
            tbxRomDirectory.Text = _config.RomDirectory;
            tbxNESEmulator.Text = _config.NESEmulator;
            tbxSNESEmulator.Text = _config.SuperNESEmulator;
            tbxN64Emulator.Text = _config.N64Emulator;
            tbxGBAEmulator.Text = _config.GBAEmulator;
            tbxNDSEmulator.Text = _config.DSEmulator;
            cbxPlatformIcon.Checked = _config.ShowPlatformIcon;
            cbxResizeIcon.Enabled = _config.ShowPlatformIcon;
            checkBox1.Checked = _config.HideSidebar;
            if (cbxResizeIcon.Enabled)
                cbxResizeIcon.Checked = _config.ResizeWithPlatformIcon;
            if (_config.IconHeight == 32)
                cmbDimensions.SelectedIndex = 0;
            else if (_config.IconHeight == 64)
                cmbDimensions.SelectedIndex = 1;
            else if (_config.IconHeight == 128)
                cmbDimensions.SelectedIndex = 2;
            else if (_config.IconHeight == 256)
                cmbDimensions.SelectedIndex = 3;
        }

        private void btnRomDirBrowse_Click(object sender, EventArgs e)
        {
            //Browse for ROM directory
            folderBrowserDialog1.Description = "ROM Directory";
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxRomDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnNESEmuBrowse_Click(object sender, EventArgs e)
        {
            //NES emu browse
            openFileDialog1.Title = "Select NES Emulator";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetParent(_config.NESEmulator).FullName;
            openFileDialog1.Filter = ".EXE Files|*.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxNESEmulator.Text = openFileDialog1.FileName;
            }
        }

        private void btnSNESEmuBrowse_Click(object sender, EventArgs e)
        {
            //SNES emu
            openFileDialog1.Title = "Select Super Nintendo Emulator";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetParent(_config.SuperNESEmulator).FullName;
            openFileDialog1.Filter = ".EXE Files|*.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxSNESEmulator.Text = openFileDialog1.FileName;
            }
        }

        private void btnN64EmuBrowse_Click(object sender, EventArgs e)
        {
            //N64 emu
            openFileDialog1.Title = "Select Nintendo 64 Emulator";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetParent(_config.N64Emulator).FullName;
            openFileDialog1.Filter = ".EXE Files|*.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxN64Emulator.Text = openFileDialog1.FileName;
            }
        }

        private void btnGBAEmuBrowse_Click(object sender, EventArgs e)
        {
            //GBA emu
            openFileDialog1.Title = "Select GameBoy Advance Emulator";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetParent(_config.GBAEmulator).FullName;
            openFileDialog1.Filter = ".EXE Files|*.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxGBAEmulator.Text = openFileDialog1.FileName;
            }
        }

        private void btnNDSEmuBrowse_Click(object sender, EventArgs e)
        {
            //DS emu
            openFileDialog1.Title = "Select Nintendo DS Emulator";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetParent(_config.DSEmulator).FullName;
            openFileDialog1.Filter = ".EXE Files|*.exe";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxNDSEmulator.Text = openFileDialog1.FileName;
            }
        }

        private void cbxResizeIcon_CheckedChanged(object sender, EventArgs e)
        {
            cbxResizeIcon.Enabled = cbxPlatformIcon.Checked;
            if (!cbxResizeIcon.Enabled)
                cbxResizeIcon.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxRomDirectory.Text))
            {
                MessageBox.Show("Please specify an existing ROM directory.");
                return;
            }

            _config.RomDirectory = tbxRomDirectory.Text;
            _config.NESEmulator = tbxNESEmulator.Text;
            _config.SuperNESEmulator = tbxSNESEmulator.Text;
            _config.N64Emulator = tbxN64Emulator.Text;
            _config.GBAEmulator = tbxGBAEmulator.Text;
            _config.DSEmulator = tbxNDSEmulator.Text;
            _config.ShowPlatformIcon = cbxPlatformIcon.Checked;
            _config.ResizeWithPlatformIcon = cbxResizeIcon.Checked;
            _config.HideSidebar = checkBox1.Checked;
            switch (cmbDimensions.SelectedIndex)
            {
                case 0:
                    _config.IconHeight = 32;
                    _config.IconWidth = 32;
                    break;
                case 1:
                    _config.IconHeight = 64;
                    _config.IconWidth = 64;
                    break;
                case 2:
                    _config.IconHeight = 128;
                    _config.IconWidth = 128;
                    break;
                case 3:
                    _config.IconHeight = 256;
                    _config.IconWidth = 256;
                    break;
            }
            _callback(_config);
            Close();
        }

        private void cbxDimensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDimensions.SelectedIndex == 0)
            {
                cbxPlatformIcon.Checked = false;
                cbxPlatformIcon.Enabled = false;
                cbxResizeIcon.Checked = false;
                cbxResizeIcon.Enabled = false;
            }
            else
            {
                cbxPlatformIcon.Enabled = true;
            }
        }
    }
}
