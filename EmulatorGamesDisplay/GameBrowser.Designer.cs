namespace EmulatorGamesDisplay
{
    partial class GameBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBrowser));
            this.lvGames = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imlGameIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblGamePlays = new System.Windows.Forms.Label();
            this.pbxGameIcon = new System.Windows.Forms.PictureBox();
            this.lblGamePlatform = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGameRating = new System.Windows.Forms.Label();
            this.lblGameDate = new System.Windows.Forms.Label();
            this.tbxGameDescription = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvGames
            // 
            this.lvGames.ContextMenuStrip = this.contextMenuStrip1;
            this.lvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGames.HideSelection = false;
            this.lvGames.LargeImageList = this.imlGameIcons;
            this.lvGames.Location = new System.Drawing.Point(0, 0);
            this.lvGames.MultiSelect = false;
            this.lvGames.Name = "lvGames";
            this.lvGames.Size = new System.Drawing.Size(727, 510);
            this.lvGames.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGames.TabIndex = 0;
            this.lvGames.UseCompatibleStateImageBehavior = false;
            this.lvGames.SelectedIndexChanged += new System.EventHandler(this.lvGames_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameToolStripMenuItem,
            this.editGameToolStripMenuItem,
            this.deleteGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 142);
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // editGameToolStripMenuItem
            // 
            this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
            this.editGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editGameToolStripMenuItem.Text = "Edit Game";
            this.editGameToolStripMenuItem.Click += new System.EventHandler(this.editGameToolStripMenuItem_Click);
            // 
            // deleteGameToolStripMenuItem
            // 
            this.deleteGameToolStripMenuItem.Name = "deleteGameToolStripMenuItem";
            this.deleteGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteGameToolStripMenuItem.Text = "Delete Game";
            this.deleteGameToolStripMenuItem.Click += new System.EventHandler(this.deleteGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imlGameIcons
            // 
            this.imlGameIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlGameIcons.ImageSize = new System.Drawing.Size(128, 128);
            this.imlGameIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 510);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblGamePlays);
            this.splitContainer2.Panel1.Controls.Add(this.pbxGameIcon);
            this.splitContainer2.Panel1.Controls.Add(this.lblGamePlatform);
            this.splitContainer2.Panel1.Controls.Add(this.lblGameName);
            this.splitContainer2.Panel1.Controls.Add(this.lblGameRating);
            this.splitContainer2.Panel1.Controls.Add(this.lblGameDate);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbxGameDescription);
            this.splitContainer2.Size = new System.Drawing.Size(268, 510);
            this.splitContainer2.SplitterDistance = 210;
            this.splitContainer2.TabIndex = 6;
            // 
            // lblGamePlays
            // 
            this.lblGamePlays.AutoSize = true;
            this.lblGamePlays.Location = new System.Drawing.Point(1, 194);
            this.lblGamePlays.Name = "lblGamePlays";
            this.lblGamePlays.Size = new System.Drawing.Size(41, 13);
            this.lblGamePlays.TabIndex = 6;
            this.lblGamePlays.Text = "PLAYS";
            this.lblGamePlays.Visible = false;
            // 
            // pbxGameIcon
            // 
            this.pbxGameIcon.Location = new System.Drawing.Point(68, 3);
            this.pbxGameIcon.Name = "pbxGameIcon";
            this.pbxGameIcon.Size = new System.Drawing.Size(128, 128);
            this.pbxGameIcon.TabIndex = 0;
            this.pbxGameIcon.TabStop = false;
            this.pbxGameIcon.Visible = false;
            this.pbxGameIcon.DoubleClick += new System.EventHandler(this.pbxGameIcon_DoubleClick);
            // 
            // lblGamePlatform
            // 
            this.lblGamePlatform.AutoSize = true;
            this.lblGamePlatform.Location = new System.Drawing.Point(1, 166);
            this.lblGamePlatform.Name = "lblGamePlatform";
            this.lblGamePlatform.Size = new System.Drawing.Size(65, 13);
            this.lblGamePlatform.TabIndex = 5;
            this.lblGamePlatform.Text = "PLATFORM";
            this.lblGamePlatform.Visible = false;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(1, 137);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(38, 13);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "NAME";
            this.lblGameName.Visible = false;
            // 
            // lblGameRating
            // 
            this.lblGameRating.AutoSize = true;
            this.lblGameRating.Location = new System.Drawing.Point(1, 180);
            this.lblGameRating.Name = "lblGameRating";
            this.lblGameRating.Size = new System.Drawing.Size(43, 13);
            this.lblGameRating.TabIndex = 4;
            this.lblGameRating.Text = "STARS";
            this.lblGameRating.Visible = false;
            // 
            // lblGameDate
            // 
            this.lblGameDate.AutoSize = true;
            this.lblGameDate.Location = new System.Drawing.Point(1, 152);
            this.lblGameDate.Name = "lblGameDate";
            this.lblGameDate.Size = new System.Drawing.Size(36, 13);
            this.lblGameDate.TabIndex = 2;
            this.lblGameDate.Text = "DATE";
            this.lblGameDate.Visible = false;
            // 
            // tbxGameDescription
            // 
            this.tbxGameDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGameDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxGameDescription.Location = new System.Drawing.Point(0, 0);
            this.tbxGameDescription.Multiline = true;
            this.tbxGameDescription.Name = "tbxGameDescription";
            this.tbxGameDescription.ReadOnly = true;
            this.tbxGameDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxGameDescription.Size = new System.Drawing.Size(268, 296);
            this.tbxGameDescription.TabIndex = 3;
            this.tbxGameDescription.Text = "DESCRIPTION";
            this.tbxGameDescription.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvGames);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(999, 510);
            this.splitContainer1.SplitterDistance = 727;
            this.splitContainer1.TabIndex = 2;
            // 
            // GameBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBrowser";
            this.Text = "Emulator Games Browser";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGames;
        private System.Windows.Forms.ImageList imlGameIcons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxGameIcon;
        private System.Windows.Forms.Label lblGameDate;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox tbxGameDescription;
        private System.Windows.Forms.Label lblGameRating;
        private System.Windows.Forms.Label lblGamePlatform;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblGamePlays;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

