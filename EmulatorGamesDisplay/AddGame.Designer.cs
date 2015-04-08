namespace EmulatorGamesDisplay
{
    sealed partial class AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxGameName = new System.Windows.Forms.TextBox();
            this.tbxGameDate = new System.Windows.Forms.TextBox();
            this.cmbGamePlatform = new System.Windows.Forms.ComboBox();
            this.tbxGameDescription = new System.Windows.Forms.TextBox();
            this.cmbGameRating = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxGameFileName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbxGameIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Platform:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Icon:";
            // 
            // tbxGameName
            // 
            this.tbxGameName.Location = new System.Drawing.Point(66, 6);
            this.tbxGameName.Name = "tbxGameName";
            this.tbxGameName.Size = new System.Drawing.Size(192, 20);
            this.tbxGameName.TabIndex = 6;
            // 
            // tbxGameDate
            // 
            this.tbxGameDate.Location = new System.Drawing.Point(66, 32);
            this.tbxGameDate.Name = "tbxGameDate";
            this.tbxGameDate.Size = new System.Drawing.Size(192, 20);
            this.tbxGameDate.TabIndex = 7;
            // 
            // cmbGamePlatform
            // 
            this.cmbGamePlatform.FormattingEnabled = true;
            this.cmbGamePlatform.Items.AddRange(new object[] {
            "NES",
            "Super Nintendo",
            "Nintendo 64",
            "GameBoy",
            "GameBoy Color",
            "GameBoy Advance",
            "Nintendo DS"});
            this.cmbGamePlatform.Location = new System.Drawing.Point(66, 58);
            this.cmbGamePlatform.Name = "cmbGamePlatform";
            this.cmbGamePlatform.Size = new System.Drawing.Size(192, 21);
            this.cmbGamePlatform.TabIndex = 8;
            // 
            // tbxGameDescription
            // 
            this.tbxGameDescription.Location = new System.Drawing.Point(15, 124);
            this.tbxGameDescription.Multiline = true;
            this.tbxGameDescription.Name = "tbxGameDescription";
            this.tbxGameDescription.Size = new System.Drawing.Size(404, 77);
            this.tbxGameDescription.TabIndex = 11;
            // 
            // cmbGameRating
            // 
            this.cmbGameRating.FormattingEnabled = true;
            this.cmbGameRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbGameRating.Location = new System.Drawing.Point(304, 84);
            this.cmbGameRating.Name = "cmbGameRating";
            this.cmbGameRating.Size = new System.Drawing.Size(38, 21);
            this.cmbGameRating.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 207);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(404, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "File name:";
            // 
            // tbxGameFileName
            // 
            this.tbxGameFileName.Location = new System.Drawing.Point(66, 85);
            this.tbxGameFileName.Name = "tbxGameFileName";
            this.tbxGameFileName.Size = new System.Drawing.Size(192, 20);
            this.tbxGameFileName.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(371, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(48, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbxGameIcon
            // 
            this.pbxGameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbxGameIcon.Image")));
            this.pbxGameIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxGameIcon.InitialImage")));
            this.pbxGameIcon.Location = new System.Drawing.Point(301, 6);
            this.pbxGameIcon.Name = "pbxGameIcon";
            this.pbxGameIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxGameIcon.TabIndex = 10;
            this.pbxGameIcon.TabStop = false;
            this.pbxGameIcon.Click += new System.EventHandler(this.pbxGameIcon_Click);
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 242);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxGameFileName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbGameRating);
            this.Controls.Add(this.tbxGameDescription);
            this.Controls.Add(this.pbxGameIcon);
            this.Controls.Add(this.cmbGamePlatform);
            this.Controls.Add(this.tbxGameDate);
            this.Controls.Add(this.tbxGameName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddGame";
            this.ShowIcon = false;
            this.Text = "Add Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxGameName;
        private System.Windows.Forms.TextBox tbxGameDate;
        private System.Windows.Forms.ComboBox cmbGamePlatform;
        private System.Windows.Forms.PictureBox pbxGameIcon;
        private System.Windows.Forms.TextBox tbxGameDescription;
        private System.Windows.Forms.ComboBox cmbGameRating;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxGameFileName;
        private System.Windows.Forms.Button btnReset;
    }
}