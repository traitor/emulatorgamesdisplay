namespace EmulatorGamesDisplay
{
    partial class IconViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconViewer));
            this.pbxGameIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGameIcon
            // 
            this.pbxGameIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxGameIcon.Location = new System.Drawing.Point(0, 0);
            this.pbxGameIcon.Name = "pbxGameIcon";
            this.pbxGameIcon.Size = new System.Drawing.Size(284, 264);
            this.pbxGameIcon.TabIndex = 0;
            this.pbxGameIcon.TabStop = false;
            // 
            // IconViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.pbxGameIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IconViewer";
            this.Text = "Icon Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGameIcon;
    }
}