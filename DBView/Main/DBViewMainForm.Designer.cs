namespace DBView.Main
{
    partial class DBViewMainForm
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
            this.dbViewMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newConnectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbViewStatusStrip = new System.Windows.Forms.StatusStrip();
            this.dbStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dbViewTreeView = new DBView.Controls.Tree.DBTreeView();
            this.queryTabs = new System.Windows.Forms.TabControl();
            this.dbViewMainMenu.SuspendLayout();
            this.dbViewStatusStrip.SuspendLayout();
            this.dbViewSplitContainer.Panel1.SuspendLayout();
            this.dbViewSplitContainer.Panel2.SuspendLayout();
            this.dbViewSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbViewMainMenu
            // 
            this.dbViewMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.searchToolStripMenuItem});
            this.dbViewMainMenu.Location = new System.Drawing.Point(0, 0);
            this.dbViewMainMenu.Name = "dbViewMainMenu";
            this.dbViewMainMenu.Size = new System.Drawing.Size(703, 24);
            this.dbViewMainMenu.TabIndex = 0;
            this.dbViewMainMenu.Text = "dbViewMainMenu";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newConnectionMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // newConnectionMenuItem
            // 
            this.newConnectionMenuItem.Name = "newConnectionMenuItem";
            this.newConnectionMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newConnectionMenuItem.Size = new System.Drawing.Size(215, 22);
            this.newConnectionMenuItem.Text = "&New Connection...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findInToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // findInToolStripMenuItem
            // 
            this.findInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.packagesToolStripMenuItem,
            this.viewsToolStripMenuItem});
            this.findInToolStripMenuItem.Name = "findInToolStripMenuItem";
            this.findInToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.findInToolStripMenuItem.Text = "Find in";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tablesToolStripMenuItem.Text = "&Tables";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.packagesToolStripMenuItem.Text = "&Packages";
            this.packagesToolStripMenuItem.Click += new System.EventHandler(this.packagesToolStripMenuItem_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewsToolStripMenuItem.Text = "&Views";
            this.viewsToolStripMenuItem.Click += new System.EventHandler(this.viewsToolStripMenuItem_Click);
            // 
            // dbViewStatusStrip
            // 
            this.dbViewStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbStatusLabel});
            this.dbViewStatusStrip.Location = new System.Drawing.Point(0, 419);
            this.dbViewStatusStrip.Name = "dbViewStatusStrip";
            this.dbViewStatusStrip.Size = new System.Drawing.Size(703, 22);
            this.dbViewStatusStrip.TabIndex = 0;
            this.dbViewStatusStrip.Text = "Ready";
            // 
            // dbStatusLabel
            // 
            this.dbStatusLabel.Name = "dbStatusLabel";
            this.dbStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.dbStatusLabel.Text = "Ready";
            // 
            // dbViewSplitContainer
            // 
            this.dbViewSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbViewSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.dbViewSplitContainer.Name = "dbViewSplitContainer";
            // 
            // dbViewSplitContainer.Panel1
            // 
            this.dbViewSplitContainer.Panel1.Controls.Add(this.dbViewTreeView);
            // 
            // dbViewSplitContainer.Panel2
            // 
            this.dbViewSplitContainer.Panel2.Controls.Add(this.queryTabs);
            this.dbViewSplitContainer.Size = new System.Drawing.Size(703, 395);
            this.dbViewSplitContainer.SplitterDistance = 234;
            this.dbViewSplitContainer.TabIndex = 0;
            this.dbViewSplitContainer.TabStop = false;
            // 
            // dbViewTreeView
            // 
            this.dbViewTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbViewTreeView.HideSelection = false;
            this.dbViewTreeView.HotTracking = true;
            this.dbViewTreeView.Location = new System.Drawing.Point(0, 0);
            this.dbViewTreeView.Name = "dbViewTreeView";
            this.dbViewTreeView.ShowLines = false;
            this.dbViewTreeView.ShowRootLines = false;
            this.dbViewTreeView.Size = new System.Drawing.Size(232, 393);
            this.dbViewTreeView.TabIndex = 1;
            this.dbViewTreeView.TabStop = false;
            // 
            // queryTabs
            // 
            this.queryTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryTabs.HotTrack = true;
            this.queryTabs.Location = new System.Drawing.Point(0, 0);
            this.queryTabs.Name = "queryTabs";
            this.queryTabs.SelectedIndex = 0;
            this.queryTabs.Size = new System.Drawing.Size(463, 393);
            this.queryTabs.TabIndex = 0;
            this.queryTabs.TabStop = false;
            // 
            // DBViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 441);
            this.Controls.Add(this.dbViewSplitContainer);
            this.Controls.Add(this.dbViewStatusStrip);
            this.Controls.Add(this.dbViewMainMenu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.dbViewMainMenu;
            this.Name = "DBViewMainForm";
            this.Text = "DBView";
            this.dbViewMainMenu.ResumeLayout(false);
            this.dbViewMainMenu.PerformLayout();
            this.dbViewStatusStrip.ResumeLayout(false);
            this.dbViewStatusStrip.PerformLayout();
            this.dbViewSplitContainer.Panel1.ResumeLayout(false);
            this.dbViewSplitContainer.Panel2.ResumeLayout(false);
            this.dbViewSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dbViewMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newConnectionMenuItem;
        private System.Windows.Forms.StatusStrip dbViewStatusStrip;
        private System.Windows.Forms.SplitContainer dbViewSplitContainer;
        private System.Windows.Forms.TabControl queryTabs;
        private Controls.Tree.DBTreeView dbViewTreeView;
        private System.Windows.Forms.ToolStripStatusLabel dbStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
    }
}