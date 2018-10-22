namespace MyWebBrowser
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
            this.favoritesButton = new DevExpress.XtraEditors.SimpleButton();
            this.historyButton = new DevExpress.XtraEditors.SimpleButton();
            this.settingsButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // favoritesButton
            // 
            this.favoritesButton.Image = ((System.Drawing.Image)(resources.GetObject("favoritesButton.Image")));
            this.favoritesButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.favoritesButton.Location = new System.Drawing.Point(90, 31);
            this.favoritesButton.Name = "favoritesButton";
            this.favoritesButton.Size = new System.Drawing.Size(100, 40);
            this.favoritesButton.TabIndex = 0;
            this.favoritesButton.Text = "Favorites";
            this.favoritesButton.Click += new System.EventHandler(this.favoritesButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Image = ((System.Drawing.Image)(resources.GetObject("historyButton.Image")));
            this.historyButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.historyButton.Location = new System.Drawing.Point(90, 100);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(100, 40);
            this.historyButton.TabIndex = 1;
            this.historyButton.Text = "History";
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(90, 170);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(100, 40);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.favoritesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton favoritesButton;
        private DevExpress.XtraEditors.SimpleButton historyButton;
        private DevExpress.XtraEditors.SimpleButton settingsButton;
    }
}