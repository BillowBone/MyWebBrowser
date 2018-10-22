namespace MyWebBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.deleteTabButton = new DevExpress.XtraEditors.SimpleButton();
            this.newTabButton = new DevExpress.XtraEditors.SimpleButton();
            this.optionsButton = new DevExpress.XtraEditors.SimpleButton();
            this.homeButton = new DevExpress.XtraEditors.SimpleButton();
            this.favoriteButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.urlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.nextButton = new DevExpress.XtraEditors.SimpleButton();
            this.previousButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fav1 = new DevExpress.XtraEditors.LabelControl();
            this.fav2 = new DevExpress.XtraEditors.LabelControl();
            this.fav3 = new DevExpress.XtraEditors.LabelControl();
            this.fav4 = new DevExpress.XtraEditors.LabelControl();
            this.fav5 = new DevExpress.XtraEditors.LabelControl();
            this.fav6 = new DevExpress.XtraEditors.LabelControl();
            this.fav7 = new DevExpress.XtraEditors.LabelControl();
            this.fav8 = new DevExpress.XtraEditors.LabelControl();
            this.fav9 = new DevExpress.XtraEditors.LabelControl();
            this.fav10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.flowLayoutPanel1);
            this.layoutControl1.Controls.Add(this.tabControl);
            this.layoutControl1.Controls.Add(this.deleteTabButton);
            this.layoutControl1.Controls.Add(this.newTabButton);
            this.layoutControl1.Controls.Add(this.optionsButton);
            this.layoutControl1.Controls.Add(this.homeButton);
            this.layoutControl1.Controls.Add(this.favoriteButton);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.urlTextEdit);
            this.layoutControl1.Controls.Add(this.refreshButton);
            this.layoutControl1.Controls.Add(this.nextButton);
            this.layoutControl1.Controls.Add(this.previousButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(967, 591);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // deleteTabButton
            // 
            this.deleteTabButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTabButton.Image")));
            this.deleteTabButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.deleteTabButton.Location = new System.Drawing.Point(785, 38);
            this.deleteTabButton.Name = "deleteTabButton";
            this.deleteTabButton.Size = new System.Drawing.Size(80, 22);
            this.deleteTabButton.StyleController = this.layoutControl1;
            this.deleteTabButton.TabIndex = 15;
            this.deleteTabButton.Text = "Delete tab";
            this.deleteTabButton.Click += new System.EventHandler(this.deleteTabButton_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            this.newTabButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.newTabButton.Location = new System.Drawing.Point(869, 38);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(86, 22);
            this.newTabButton.StyleController = this.layoutControl1;
            this.newTabButton.TabIndex = 14;
            this.newTabButton.Text = "New tab";
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Image = ((System.Drawing.Image)(resources.GetObject("optionsButton.Image")));
            this.optionsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.optionsButton.Location = new System.Drawing.Point(929, 12);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(26, 22);
            this.optionsButton.StyleController = this.layoutControl1;
            this.optionsButton.TabIndex = 12;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.homeButton.Location = new System.Drawing.Point(102, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(26, 22);
            this.homeButton.StyleController = this.layoutControl1;
            this.homeButton.TabIndex = 11;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Image = ((System.Drawing.Image)(resources.GetObject("favoriteButton.Image")));
            this.favoriteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.favoriteButton.Location = new System.Drawing.Point(899, 12);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(26, 22);
            this.favoriteButton.StyleController = this.layoutControl1;
            this.favoriteButton.TabIndex = 10;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.searchButton.Location = new System.Drawing.Point(869, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(26, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 9;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // urlTextEdit
            // 
            this.urlTextEdit.Location = new System.Drawing.Point(132, 12);
            this.urlTextEdit.Name = "urlTextEdit";
            this.urlTextEdit.Size = new System.Drawing.Size(733, 20);
            this.urlTextEdit.StyleController = this.layoutControl1;
            this.urlTextEdit.TabIndex = 8;
            this.urlTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlTextEdit_KeyPress);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.refreshButton.Location = new System.Drawing.Point(72, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(26, 22);
            this.refreshButton.StyleController = this.layoutControl1;
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.nextButton.Location = new System.Drawing.Point(42, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(26, 22);
            this.nextButton.StyleController = this.layoutControl1;
            this.nextButton.TabIndex = 6;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.previousButton.Location = new System.Drawing.Point(12, 12);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(26, 22);
            this.previousButton.StyleController = this.layoutControl1;
            this.previousButton.TabIndex = 5;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem12});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(967, 591);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.previousButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.nextButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(30, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.refreshButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(60, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.urlTextEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(120, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(737, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.searchButton;
            this.layoutControlItem6.Location = new System.Drawing.Point(857, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.favoriteButton;
            this.layoutControlItem7.Location = new System.Drawing.Point(887, 0);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.homeButton;
            this.layoutControlItem8.Location = new System.Drawing.Point(90, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.optionsButton;
            this.layoutControlItem9.Location = new System.Drawing.Point(917, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(30, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.newTabButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(857, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.deleteTabButton;
            this.layoutControlItem11.Location = new System.Drawing.Point(773, 26);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(84, 26);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 64);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 515);
            this.tabControl.TabIndex = 16;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.tabControl;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(947, 519);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(763, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(929, 483);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.DocumentCompleted);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fav1);
            this.flowLayoutPanel1.Controls.Add(this.fav2);
            this.flowLayoutPanel1.Controls.Add(this.fav3);
            this.flowLayoutPanel1.Controls.Add(this.fav4);
            this.flowLayoutPanel1.Controls.Add(this.fav5);
            this.flowLayoutPanel1.Controls.Add(this.fav6);
            this.flowLayoutPanel1.Controls.Add(this.fav7);
            this.flowLayoutPanel1.Controls.Add(this.fav8);
            this.flowLayoutPanel1.Controls.Add(this.fav9);
            this.flowLayoutPanel1.Controls.Add(this.fav10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 22);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.flowLayoutPanel1;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(763, 26);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // fav1
            // 
            this.fav1.Location = new System.Drawing.Point(3, 3);
            this.fav1.Name = "fav1";
            this.fav1.Size = new System.Drawing.Size(63, 13);
            this.fav1.TabIndex = 0;
            this.fav1.Text = "labelControl1";
            this.fav1.Visible = false;
            this.fav1.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav2
            // 
            this.fav2.Location = new System.Drawing.Point(72, 3);
            this.fav2.Name = "fav2";
            this.fav2.Size = new System.Drawing.Size(63, 13);
            this.fav2.TabIndex = 1;
            this.fav2.Text = "labelControl2";
            this.fav2.Visible = false;
            this.fav2.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav3
            // 
            this.fav3.Location = new System.Drawing.Point(141, 3);
            this.fav3.Name = "fav3";
            this.fav3.Size = new System.Drawing.Size(63, 13);
            this.fav3.TabIndex = 2;
            this.fav3.Text = "labelControl3";
            this.fav3.Visible = false;
            this.fav3.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav4
            // 
            this.fav4.Location = new System.Drawing.Point(210, 3);
            this.fav4.Name = "fav4";
            this.fav4.Size = new System.Drawing.Size(63, 13);
            this.fav4.TabIndex = 3;
            this.fav4.Text = "labelControl4";
            this.fav4.Visible = false;
            this.fav4.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav5
            // 
            this.fav5.Location = new System.Drawing.Point(279, 3);
            this.fav5.Name = "fav5";
            this.fav5.Size = new System.Drawing.Size(63, 13);
            this.fav5.TabIndex = 4;
            this.fav5.Text = "labelControl5";
            this.fav5.Visible = false;
            this.fav5.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav6
            // 
            this.fav6.Location = new System.Drawing.Point(348, 3);
            this.fav6.Name = "fav6";
            this.fav6.Size = new System.Drawing.Size(63, 13);
            this.fav6.TabIndex = 5;
            this.fav6.Text = "labelControl6";
            this.fav6.Visible = false;
            this.fav6.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav7
            // 
            this.fav7.Location = new System.Drawing.Point(417, 3);
            this.fav7.Name = "fav7";
            this.fav7.Size = new System.Drawing.Size(63, 13);
            this.fav7.TabIndex = 6;
            this.fav7.Text = "labelControl7";
            this.fav7.Visible = false;
            this.fav7.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav8
            // 
            this.fav8.Location = new System.Drawing.Point(486, 3);
            this.fav8.Name = "fav8";
            this.fav8.Size = new System.Drawing.Size(63, 13);
            this.fav8.TabIndex = 7;
            this.fav8.Text = "labelControl8";
            this.fav8.Visible = false;
            this.fav8.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav9
            // 
            this.fav9.Location = new System.Drawing.Point(555, 3);
            this.fav9.Name = "fav9";
            this.fav9.Size = new System.Drawing.Size(63, 13);
            this.fav9.TabIndex = 8;
            this.fav9.Text = "labelControl9";
            this.fav9.Visible = false;
            this.fav9.Click += new System.EventHandler(this.fav_Click);
            // 
            // fav10
            // 
            this.fav10.Location = new System.Drawing.Point(624, 3);
            this.fav10.Name = "fav10";
            this.fav10.Size = new System.Drawing.Size(69, 13);
            this.fav10.TabIndex = 9;
            this.fav10.Text = "labelControl10";
            this.fav10.Visible = false;
            this.fav10.Click += new System.EventHandler(this.fav_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 591);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "My Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton nextButton;
        private DevExpress.XtraEditors.SimpleButton previousButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.TextEdit urlTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton favoriteButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton homeButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton optionsButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton newTabButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton deleteTabButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl fav1;
        private DevExpress.XtraEditors.LabelControl fav2;
        private DevExpress.XtraEditors.LabelControl fav3;
        private DevExpress.XtraEditors.LabelControl fav4;
        private DevExpress.XtraEditors.LabelControl fav5;
        private DevExpress.XtraEditors.LabelControl fav6;
        private DevExpress.XtraEditors.LabelControl fav7;
        private DevExpress.XtraEditors.LabelControl fav8;
        private DevExpress.XtraEditors.LabelControl fav9;
        private DevExpress.XtraEditors.LabelControl fav10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
    }
}

