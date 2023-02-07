namespace Web_Browser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.Minbtn = new System.Windows.Forms.Label();
            this.Maxbtn = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Label();
            this.BrowserTitle = new System.Windows.Forms.Label();
            this.forbtn = new System.Windows.Forms.Button();
            this.tabhead = new System.Windows.Forms.TabControl();
            this.relbtn = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.favbtn = new System.Windows.Forms.Button();
            this.hisbtn = new System.Windows.Forms.Button();
            this.bulkbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.addtab = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.deltab = new System.Windows.Forms.Button();
            this.contextMenuFavorite = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BulkFile = new System.Windows.Forms.OpenFileDialog();
            this.favlist = new System.Windows.Forms.ListBox();
            this.hislist = new System.Windows.Forms.ListBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settingsbtn = new System.Windows.Forms.Button();
            this.Settingsmenu = new System.Windows.Forms.Panel();
            this.clearfavourite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setdefaultpage = new System.Windows.Forms.Button();
            this.clearhistory = new System.Windows.Forms.Button();
            this.bookmarkpage = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.contextMenuFavorite.SuspendLayout();
            this.contextMenuHistory.SuspendLayout();
            this.Settingsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel.Controls.Add(this.Minbtn);
            this.Panel.Controls.Add(this.Maxbtn);
            this.Panel.Controls.Add(this.Closebtn);
            this.Panel.Controls.Add(this.BrowserTitle);
            this.Panel.Location = new System.Drawing.Point(-2, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1209, 35);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // Minbtn
            // 
            this.Minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minbtn.AutoSize = true;
            this.Minbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minbtn.ForeColor = System.Drawing.Color.Brown;
            this.Minbtn.Location = new System.Drawing.Point(1057, 7);
            this.Minbtn.Name = "Minbtn";
            this.Minbtn.Size = new System.Drawing.Size(37, 19);
            this.Minbtn.TabIndex = 3;
            this.Minbtn.Text = "Min";
            this.Minbtn.Click += new System.EventHandler(this.Min_Click);
            // 
            // Maxbtn
            // 
            this.Maxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxbtn.AutoSize = true;
            this.Maxbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Maxbtn.ForeColor = System.Drawing.Color.Brown;
            this.Maxbtn.Location = new System.Drawing.Point(1101, 7);
            this.Maxbtn.Name = "Maxbtn";
            this.Maxbtn.Size = new System.Drawing.Size(43, 19);
            this.Maxbtn.TabIndex = 2;
            this.Maxbtn.Text = "Max";
            this.Maxbtn.Click += new System.EventHandler(this.Max_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebtn.AutoSize = true;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Closebtn.ForeColor = System.Drawing.Color.Brown;
            this.Closebtn.Location = new System.Drawing.Point(1146, 7);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(55, 19);
            this.Closebtn.TabIndex = 1;
            this.Closebtn.Text = "Close";
            this.Closebtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // BrowserTitle
            // 
            this.BrowserTitle.AutoSize = true;
            this.BrowserTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BrowserTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.BrowserTitle.Location = new System.Drawing.Point(6, 7);
            this.BrowserTitle.Name = "BrowserTitle";
            this.BrowserTitle.Size = new System.Drawing.Size(120, 19);
            this.BrowserTitle.TabIndex = 0;
            this.BrowserTitle.Text = "Web Browser";
            this.BrowserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowserTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // forbtn
            // 
            this.forbtn.AutoSize = true;
            this.forbtn.FlatAppearance.BorderSize = 0;
            this.forbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.forbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forbtn.ForeColor = System.Drawing.Color.Maroon;
            this.forbtn.Location = new System.Drawing.Point(62, 42);
            this.forbtn.Name = "forbtn";
            this.forbtn.Size = new System.Drawing.Size(45, 45);
            this.forbtn.TabIndex = 2;
            this.forbtn.Text = ">>";
            this.forbtn.UseVisualStyleBackColor = true;
            this.forbtn.Click += new System.EventHandler(this.Forward_Click);
            // 
            // tabhead
            // 
            this.tabhead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabhead.Location = new System.Drawing.Point(11, 98);
            this.tabhead.Name = "tabhead";
            this.tabhead.SelectedIndex = 0;
            this.tabhead.Size = new System.Drawing.Size(1184, 595);
            this.tabhead.TabIndex = 7;
            this.tabhead.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // relbtn
            // 
            this.relbtn.AutoSize = true;
            this.relbtn.FlatAppearance.BorderSize = 0;
            this.relbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.relbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.relbtn.ForeColor = System.Drawing.Color.Maroon;
            this.relbtn.Location = new System.Drawing.Point(113, 42);
            this.relbtn.Name = "relbtn";
            this.relbtn.Size = new System.Drawing.Size(75, 45);
            this.relbtn.TabIndex = 8;
            this.relbtn.Text = "Reload";
            this.relbtn.UseVisualStyleBackColor = true;
            this.relbtn.Click += new System.EventHandler(this.Reload_Click);
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb1.ForeColor = System.Drawing.Color.Black;
            this.tb1.Location = new System.Drawing.Point(194, 55);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(405, 19);
            this.tb1.TabIndex = 9;
            this.tb1.Text = " ";
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb1_KeyDown);
            // 
            // favbtn
            // 
            this.favbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favbtn.AutoSize = true;
            this.favbtn.FlatAppearance.BorderSize = 0;
            this.favbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.favbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.favbtn.ForeColor = System.Drawing.Color.Maroon;
            this.favbtn.Location = new System.Drawing.Point(808, 42);
            this.favbtn.Name = "favbtn";
            this.favbtn.Size = new System.Drawing.Size(111, 45);
            this.favbtn.TabIndex = 13;
            this.favbtn.Text = "Favourites";
            this.favbtn.UseVisualStyleBackColor = true;
            this.favbtn.Click += new System.EventHandler(this.Favourite_Click);
            this.favbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Favbtn_KeyDown);
            // 
            // hisbtn
            // 
            this.hisbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hisbtn.AutoSize = true;
            this.hisbtn.FlatAppearance.BorderSize = 0;
            this.hisbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.hisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hisbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hisbtn.ForeColor = System.Drawing.Color.Maroon;
            this.hisbtn.Location = new System.Drawing.Point(925, 42);
            this.hisbtn.Name = "hisbtn";
            this.hisbtn.Size = new System.Drawing.Size(79, 45);
            this.hisbtn.TabIndex = 14;
            this.hisbtn.Text = "History";
            this.hisbtn.UseVisualStyleBackColor = true;
            this.hisbtn.Click += new System.EventHandler(this.History_Click);
            this.hisbtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hisbtn_KeyDown);
            // 
            // bulkbtn
            // 
            this.bulkbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bulkbtn.AutoSize = true;
            this.bulkbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.bulkbtn.FlatAppearance.BorderSize = 0;
            this.bulkbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.bulkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulkbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bulkbtn.ForeColor = System.Drawing.Color.Maroon;
            this.bulkbtn.Location = new System.Drawing.Point(1006, 42);
            this.bulkbtn.Name = "bulkbtn";
            this.bulkbtn.Size = new System.Drawing.Size(146, 45);
            this.bulkbtn.TabIndex = 15;
            this.bulkbtn.Text = "Bulk Download";
            this.bulkbtn.UseVisualStyleBackColor = false;
            this.bulkbtn.Click += new System.EventHandler(this.Bulk_Click);
            // 
            // backbtn
            // 
            this.backbtn.AutoSize = true;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbtn.ForeColor = System.Drawing.Color.Maroon;
            this.backbtn.Location = new System.Drawing.Point(11, 42);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(45, 45);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "<<";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.Back_Click);
            // 
            // addtab
            // 
            this.addtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addtab.AutoSize = true;
            this.addtab.FlatAppearance.BorderSize = 0;
            this.addtab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.addtab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtab.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addtab.ForeColor = System.Drawing.Color.Maroon;
            this.addtab.Location = new System.Drawing.Point(677, 42);
            this.addtab.Name = "addtab";
            this.addtab.Size = new System.Drawing.Size(66, 45);
            this.addtab.TabIndex = 11;
            this.addtab.Text = "+Tab";
            this.addtab.UseVisualStyleBackColor = true;
            this.addtab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // homebtn
            // 
            this.homebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homebtn.AutoSize = true;
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homebtn.ForeColor = System.Drawing.Color.Maroon;
            this.homebtn.Location = new System.Drawing.Point(603, 42);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(72, 45);
            this.homebtn.TabIndex = 10;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.Home_Click);
            // 
            // deltab
            // 
            this.deltab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deltab.AutoSize = true;
            this.deltab.FlatAppearance.BorderSize = 0;
            this.deltab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.deltab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deltab.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deltab.ForeColor = System.Drawing.Color.Maroon;
            this.deltab.Location = new System.Drawing.Point(745, 42);
            this.deltab.Name = "deltab";
            this.deltab.Size = new System.Drawing.Size(61, 45);
            this.deltab.TabIndex = 12;
            this.deltab.Text = "-Tab";
            this.deltab.UseVisualStyleBackColor = true;
            this.deltab.Click += new System.EventHandler(this.DelTab_Click);
            // 
            // contextMenuFavorite
            // 
            this.contextMenuFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenuFavorite.BackgroundImage")));
            this.contextMenuFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextMenuFavorite.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contextMenuFavorite.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuFavorite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuFavorite.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuFavorite.Name = "contextMenuFavorite";
            this.contextMenuFavorite.Size = new System.Drawing.Size(123, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem.Text = "Edit ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.FavEDIT_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.FavDELETE_Click);
            // 
            // contextMenuHistory
            // 
            this.contextMenuHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contextMenuHistory.BackgroundImage = global::Web_Browser.Properties.Resources.download;
            this.contextMenuHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextMenuHistory.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contextMenuHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.contextMenuHistory.Name = "contextMenuHistory";
            this.contextMenuHistory.Size = new System.Drawing.Size(132, 28);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.HisDELETE_Click);
            // 
            // BulkFile
            // 
            this.BulkFile.Filter = "*.txt|";
            this.BulkFile.Title = "Select a txt file";
            // 
            // favlist
            // 
            this.favlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favlist.BackColor = System.Drawing.Color.SeaShell;
            this.favlist.ForeColor = System.Drawing.Color.DarkRed;
            this.favlist.FormattingEnabled = true;
            this.favlist.ItemHeight = 19;
            this.favlist.Location = new System.Drawing.Point(603, 94);
            this.favlist.Name = "favlist";
            this.favlist.Size = new System.Drawing.Size(377, 593);
            this.favlist.TabIndex = 16;
            this.favlist.Visible = false;
            this.favlist.SelectedIndexChanged += new System.EventHandler(this.Favlist_SelectedIndexChanged);
            this.favlist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Favlist_MouseUp);
            // 
            // hislist
            // 
            this.hislist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hislist.BackColor = System.Drawing.Color.SeaShell;
            this.hislist.ForeColor = System.Drawing.Color.DarkRed;
            this.hislist.FormattingEnabled = true;
            this.hislist.ItemHeight = 19;
            this.hislist.Location = new System.Drawing.Point(694, 94);
            this.hislist.Name = "hislist";
            this.hislist.Size = new System.Drawing.Size(377, 593);
            this.hislist.TabIndex = 17;
            this.hislist.Visible = false;
            this.hislist.SelectedIndexChanged += new System.EventHandler(this.Hislist_SelectedIndexChanged);
            this.hislist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Hislist_MouseUp);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "Bookmark Page";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 4);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(26, 4);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settingsbtn.AutoSize = true;
            this.Settingsbtn.FlatAppearance.BorderSize = 0;
            this.Settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Settingsbtn.Image")));
            this.Settingsbtn.Location = new System.Drawing.Point(1158, 44);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(41, 38);
            this.Settingsbtn.TabIndex = 18;
            this.Settingsbtn.UseVisualStyleBackColor = true;
            this.Settingsbtn.Click += new System.EventHandler(this.Settingsbtn_Click);
            // 
            // Settingsmenu
            // 
            this.Settingsmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settingsmenu.BackColor = System.Drawing.Color.SeaShell;
            this.Settingsmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Settingsmenu.Controls.Add(this.clearfavourite);
            this.Settingsmenu.Controls.Add(this.label2);
            this.Settingsmenu.Controls.Add(this.label1);
            this.Settingsmenu.Controls.Add(this.setdefaultpage);
            this.Settingsmenu.Controls.Add(this.clearhistory);
            this.Settingsmenu.Controls.Add(this.bookmarkpage);
            this.Settingsmenu.Location = new System.Drawing.Point(949, 95);
            this.Settingsmenu.Name = "Settingsmenu";
            this.Settingsmenu.Size = new System.Drawing.Size(246, 206);
            this.Settingsmenu.TabIndex = 19;
            this.Settingsmenu.Visible = false;
            // 
            // clearfavourite
            // 
            this.clearfavourite.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearfavourite.FlatAppearance.BorderSize = 0;
            this.clearfavourite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.clearfavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearfavourite.ForeColor = System.Drawing.Color.Maroon;
            this.clearfavourite.Location = new System.Drawing.Point(0, 153);
            this.clearfavourite.Name = "clearfavourite";
            this.clearfavourite.Size = new System.Drawing.Size(244, 52);
            this.clearfavourite.TabIndex = 22;
            this.clearfavourite.Text = "Clear Favourite";
            this.clearfavourite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearfavourite.UseVisualStyleBackColor = true;
            this.clearfavourite.Click += new System.EventHandler(this.ClearFavourite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(160, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "\"Delete\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "\"Ctrl + D\"";
            // 
            // setdefaultpage
            // 
            this.setdefaultpage.Dock = System.Windows.Forms.DockStyle.Top;
            this.setdefaultpage.FlatAppearance.BorderSize = 0;
            this.setdefaultpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.setdefaultpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setdefaultpage.ForeColor = System.Drawing.Color.Maroon;
            this.setdefaultpage.Location = new System.Drawing.Point(0, 102);
            this.setdefaultpage.Name = "setdefaultpage";
            this.setdefaultpage.Size = new System.Drawing.Size(244, 51);
            this.setdefaultpage.TabIndex = 2;
            this.setdefaultpage.Text = "Edit Home Page";
            this.setdefaultpage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setdefaultpage.UseVisualStyleBackColor = true;
            this.setdefaultpage.Click += new System.EventHandler(this.Setdefaultpage_Click);
            // 
            // clearhistory
            // 
            this.clearhistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearhistory.FlatAppearance.BorderSize = 0;
            this.clearhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.clearhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearhistory.ForeColor = System.Drawing.Color.Maroon;
            this.clearhistory.Location = new System.Drawing.Point(0, 51);
            this.clearhistory.Name = "clearhistory";
            this.clearhistory.Size = new System.Drawing.Size(244, 51);
            this.clearhistory.TabIndex = 1;
            this.clearhistory.Text = "Clear History";
            this.clearhistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearhistory.UseVisualStyleBackColor = true;
            this.clearhistory.Click += new System.EventHandler(this.Clearhistory_Click);
            // 
            // bookmarkpage
            // 
            this.bookmarkpage.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookmarkpage.FlatAppearance.BorderSize = 0;
            this.bookmarkpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.bookmarkpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookmarkpage.ForeColor = System.Drawing.Color.Maroon;
            this.bookmarkpage.Location = new System.Drawing.Point(0, 0);
            this.bookmarkpage.Name = "bookmarkpage";
            this.bookmarkpage.Size = new System.Drawing.Size(244, 51);
            this.bookmarkpage.TabIndex = 0;
            this.bookmarkpage.Text = "Bookmark Page";
            this.bookmarkpage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookmarkpage.UseVisualStyleBackColor = true;
            this.bookmarkpage.Click += new System.EventHandler(this.Bookmarkpage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1206, 705);
            this.Controls.Add(this.Settingsmenu);
            this.Controls.Add(this.hislist);
            this.Controls.Add(this.favlist);
            this.Controls.Add(this.bulkbtn);
            this.Controls.Add(this.deltab);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.addtab);
            this.Controls.Add(this.relbtn);
            this.Controls.Add(this.hisbtn);
            this.Controls.Add(this.tabhead);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.forbtn);
            this.Controls.Add(this.favbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Settingsbtn);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.contextMenuFavorite.ResumeLayout(false);
            this.contextMenuHistory.ResumeLayout(false);
            this.Settingsmenu.ResumeLayout(false);
            this.Settingsmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel;
        public Label BrowserTitle;
        private Label Closebtn;
        private Label Maxbtn;
        private Label Minbtn;
        private Button forbtn;
        public TabControl tabhead;
        private Button relbtn;
        public TextBox tb1;
        private Button favbtn;
        private Button hisbtn;
        private Button bulkbtn;
        private Button backbtn;
        private Button addtab;
        private Button homebtn;
        private Button deltab;
        public ContextMenuStrip contextMenuFavorite;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        public ContextMenuStrip contextMenuHistory;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private OpenFileDialog BulkFile;
        public ListBox favlist;
        public ListBox hislist;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem clearHistoryToolStripMenuItem;
        private Button Settingsbtn;
        public Panel Settingsmenu;
        private Button setdefaultpage;
        private Button clearhistory;
        private Button bookmarkpage;
        private Label label2;
        private Label label1;
        private Button clearfavourite;
    }
}