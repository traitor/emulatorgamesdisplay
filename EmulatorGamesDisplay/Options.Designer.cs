namespace EmulatorGamesDisplay
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRomDirectory = new System.Windows.Forms.TextBox();
            this.btnRomDirBrowse = new System.Windows.Forms.Button();
            this.btnNESEmuBrowse = new System.Windows.Forms.Button();
            this.tbxNESEmulator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSNESEmuBrowse = new System.Windows.Forms.Button();
            this.tbxSNESEmulator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnN64EmuBrowse = new System.Windows.Forms.Button();
            this.tbxN64Emulator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGBAEmuBrowse = new System.Windows.Forms.Button();
            this.tbxGBAEmulator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNDSEmuBrowse = new System.Windows.Forms.Button();
            this.tbxNDSEmulator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxIconSettings = new System.Windows.Forms.GroupBox();
            this.cbxResizeIcon = new System.Windows.Forms.CheckBox();
            this.cbxPlatformIcon = new System.Windows.Forms.CheckBox();
            this.cmbDimensions = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxEmulators = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbxIconSettings.SuspendLayout();
            this.gbxEmulators.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROM Directory:";
            // 
            // tbxRomDirectory
            // 
            this.tbxRomDirectory.Location = new System.Drawing.Point(15, 25);
            this.tbxRomDirectory.Name = "tbxRomDirectory";
            this.tbxRomDirectory.Size = new System.Drawing.Size(237, 20);
            this.tbxRomDirectory.TabIndex = 1;
            // 
            // btnRomDirBrowse
            // 
            this.btnRomDirBrowse.Location = new System.Drawing.Point(258, 23);
            this.btnRomDirBrowse.Name = "btnRomDirBrowse";
            this.btnRomDirBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnRomDirBrowse.TabIndex = 2;
            this.btnRomDirBrowse.Text = "Browse...";
            this.btnRomDirBrowse.UseVisualStyleBackColor = true;
            this.btnRomDirBrowse.Click += new System.EventHandler(this.btnRomDirBrowse_Click);
            // 
            // btnNESEmuBrowse
            // 
            this.btnNESEmuBrowse.Location = new System.Drawing.Point(237, 30);
            this.btnNESEmuBrowse.Name = "btnNESEmuBrowse";
            this.btnNESEmuBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnNESEmuBrowse.TabIndex = 5;
            this.btnNESEmuBrowse.Text = "Browse...";
            this.btnNESEmuBrowse.UseVisualStyleBackColor = true;
            this.btnNESEmuBrowse.Click += new System.EventHandler(this.btnNESEmuBrowse_Click);
            // 
            // tbxNESEmulator
            // 
            this.tbxNESEmulator.Location = new System.Drawing.Point(9, 32);
            this.tbxNESEmulator.Name = "tbxNESEmulator";
            this.tbxNESEmulator.Size = new System.Drawing.Size(222, 20);
            this.tbxNESEmulator.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NES Emulator:";
            // 
            // btnSNESEmuBrowse
            // 
            this.btnSNESEmuBrowse.Location = new System.Drawing.Point(237, 69);
            this.btnSNESEmuBrowse.Name = "btnSNESEmuBrowse";
            this.btnSNESEmuBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnSNESEmuBrowse.TabIndex = 8;
            this.btnSNESEmuBrowse.Text = "Browse...";
            this.btnSNESEmuBrowse.UseVisualStyleBackColor = true;
            this.btnSNESEmuBrowse.Click += new System.EventHandler(this.btnSNESEmuBrowse_Click);
            // 
            // tbxSNESEmulator
            // 
            this.tbxSNESEmulator.Location = new System.Drawing.Point(9, 71);
            this.tbxSNESEmulator.Name = "tbxSNESEmulator";
            this.tbxSNESEmulator.Size = new System.Drawing.Size(222, 20);
            this.tbxSNESEmulator.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Super Nintendo Emulator:";
            // 
            // btnN64EmuBrowse
            // 
            this.btnN64EmuBrowse.Location = new System.Drawing.Point(237, 108);
            this.btnN64EmuBrowse.Name = "btnN64EmuBrowse";
            this.btnN64EmuBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnN64EmuBrowse.TabIndex = 11;
            this.btnN64EmuBrowse.Text = "Browse...";
            this.btnN64EmuBrowse.UseVisualStyleBackColor = true;
            this.btnN64EmuBrowse.Click += new System.EventHandler(this.btnN64EmuBrowse_Click);
            // 
            // tbxN64Emulator
            // 
            this.tbxN64Emulator.Location = new System.Drawing.Point(9, 110);
            this.tbxN64Emulator.Name = "tbxN64Emulator";
            this.tbxN64Emulator.Size = new System.Drawing.Size(222, 20);
            this.tbxN64Emulator.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nintendo 64 Emulator:";
            // 
            // btnGBAEmuBrowse
            // 
            this.btnGBAEmuBrowse.Location = new System.Drawing.Point(237, 147);
            this.btnGBAEmuBrowse.Name = "btnGBAEmuBrowse";
            this.btnGBAEmuBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnGBAEmuBrowse.TabIndex = 14;
            this.btnGBAEmuBrowse.Text = "Browse...";
            this.btnGBAEmuBrowse.UseVisualStyleBackColor = true;
            this.btnGBAEmuBrowse.Click += new System.EventHandler(this.btnGBAEmuBrowse_Click);
            // 
            // tbxGBAEmulator
            // 
            this.tbxGBAEmulator.Location = new System.Drawing.Point(9, 149);
            this.tbxGBAEmulator.Name = "tbxGBAEmulator";
            this.tbxGBAEmulator.Size = new System.Drawing.Size(222, 20);
            this.tbxGBAEmulator.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "GameBoy Advance Emulator:";
            // 
            // btnNDSEmuBrowse
            // 
            this.btnNDSEmuBrowse.Location = new System.Drawing.Point(237, 186);
            this.btnNDSEmuBrowse.Name = "btnNDSEmuBrowse";
            this.btnNDSEmuBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnNDSEmuBrowse.TabIndex = 17;
            this.btnNDSEmuBrowse.Text = "Browse...";
            this.btnNDSEmuBrowse.UseVisualStyleBackColor = true;
            this.btnNDSEmuBrowse.Click += new System.EventHandler(this.btnNDSEmuBrowse_Click);
            // 
            // tbxNDSEmulator
            // 
            this.tbxNDSEmulator.Location = new System.Drawing.Point(9, 188);
            this.tbxNDSEmulator.Name = "tbxNDSEmulator";
            this.tbxNDSEmulator.Size = new System.Drawing.Size(222, 20);
            this.tbxNDSEmulator.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nintendo DS Emulator:";
            // 
            // gbxIconSettings
            // 
            this.gbxIconSettings.Controls.Add(this.cbxResizeIcon);
            this.gbxIconSettings.Controls.Add(this.cbxPlatformIcon);
            this.gbxIconSettings.Controls.Add(this.cmbDimensions);
            this.gbxIconSettings.Controls.Add(this.label7);
            this.gbxIconSettings.Location = new System.Drawing.Point(15, 294);
            this.gbxIconSettings.Name = "gbxIconSettings";
            this.gbxIconSettings.Size = new System.Drawing.Size(310, 63);
            this.gbxIconSettings.TabIndex = 18;
            this.gbxIconSettings.TabStop = false;
            this.gbxIconSettings.Text = "Icon Settings";
            // 
            // cbxResizeIcon
            // 
            this.cbxResizeIcon.AutoSize = true;
            this.cbxResizeIcon.Enabled = false;
            this.cbxResizeIcon.Location = new System.Drawing.Point(144, 36);
            this.cbxResizeIcon.Name = "cbxResizeIcon";
            this.cbxResizeIcon.Size = new System.Drawing.Size(113, 17);
            this.cbxResizeIcon.TabIndex = 3;
            this.cbxResizeIcon.Text = "Resize Game Icon";
            this.cbxResizeIcon.UseVisualStyleBackColor = true;
            // 
            // cbxPlatformIcon
            // 
            this.cbxPlatformIcon.AutoSize = true;
            this.cbxPlatformIcon.Location = new System.Drawing.Point(144, 12);
            this.cbxPlatformIcon.Name = "cbxPlatformIcon";
            this.cbxPlatformIcon.Size = new System.Drawing.Size(118, 17);
            this.cbxPlatformIcon.TabIndex = 2;
            this.cbxPlatformIcon.Text = "Show Platform Icon";
            this.cbxPlatformIcon.UseVisualStyleBackColor = true;
            this.cbxPlatformIcon.CheckedChanged += new System.EventHandler(this.cbxResizeIcon_CheckedChanged);
            // 
            // cmbDimensions
            // 
            this.cmbDimensions.FormattingEnabled = true;
            this.cmbDimensions.Items.AddRange(new object[] {
            "32x32",
            "64x64",
            "128x128",
            "256x256"});
            this.cmbDimensions.Location = new System.Drawing.Point(9, 32);
            this.cmbDimensions.Name = "cmbDimensions";
            this.cmbDimensions.Size = new System.Drawing.Size(121, 21);
            this.cmbDimensions.TabIndex = 1;
            this.cmbDimensions.SelectedIndexChanged += new System.EventHandler(this.cbxDimensions_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dimensions:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(310, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxEmulators
            // 
            this.gbxEmulators.Controls.Add(this.label2);
            this.gbxEmulators.Controls.Add(this.tbxNESEmulator);
            this.gbxEmulators.Controls.Add(this.btnNESEmuBrowse);
            this.gbxEmulators.Controls.Add(this.btnNDSEmuBrowse);
            this.gbxEmulators.Controls.Add(this.label3);
            this.gbxEmulators.Controls.Add(this.tbxNDSEmulator);
            this.gbxEmulators.Controls.Add(this.tbxSNESEmulator);
            this.gbxEmulators.Controls.Add(this.label6);
            this.gbxEmulators.Controls.Add(this.btnSNESEmuBrowse);
            this.gbxEmulators.Controls.Add(this.btnGBAEmuBrowse);
            this.gbxEmulators.Controls.Add(this.label4);
            this.gbxEmulators.Controls.Add(this.tbxGBAEmulator);
            this.gbxEmulators.Controls.Add(this.tbxN64Emulator);
            this.gbxEmulators.Controls.Add(this.label5);
            this.gbxEmulators.Controls.Add(this.btnN64EmuBrowse);
            this.gbxEmulators.Location = new System.Drawing.Point(15, 71);
            this.gbxEmulators.Name = "gbxEmulators";
            this.gbxEmulators.Size = new System.Drawing.Size(310, 217);
            this.gbxEmulators.TabIndex = 20;
            this.gbxEmulators.TabStop = false;
            this.gbxEmulators.Text = "Emulators";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Hide Sidebar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 404);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gbxEmulators);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxIconSettings);
            this.Controls.Add(this.btnRomDirBrowse);
            this.Controls.Add(this.tbxRomDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.gbxIconSettings.ResumeLayout(false);
            this.gbxIconSettings.PerformLayout();
            this.gbxEmulators.ResumeLayout(false);
            this.gbxEmulators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRomDirectory;
        private System.Windows.Forms.Button btnRomDirBrowse;
        private System.Windows.Forms.Button btnNESEmuBrowse;
        private System.Windows.Forms.TextBox tbxNESEmulator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSNESEmuBrowse;
        private System.Windows.Forms.TextBox tbxSNESEmulator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnN64EmuBrowse;
        private System.Windows.Forms.TextBox tbxN64Emulator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGBAEmuBrowse;
        private System.Windows.Forms.TextBox tbxGBAEmulator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNDSEmuBrowse;
        private System.Windows.Forms.TextBox tbxNDSEmulator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxIconSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxResizeIcon;
        private System.Windows.Forms.CheckBox cbxPlatformIcon;
        private System.Windows.Forms.ComboBox cmbDimensions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxEmulators;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}