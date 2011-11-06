namespace DBView.Controls.Tree
{
    partial class DBTreeView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewContextMenu
            // 
            this.treeViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyNameMenuItem});
            this.treeViewContextMenu.Name = "treeViewContextMenu";
            this.treeViewContextMenu.Size = new System.Drawing.Size(131, 26);
            // 
            // copyNameMenuItem
            // 
            this.copyNameMenuItem.Name = "copyNameMenuItem";
            this.copyNameMenuItem.ShowShortcutKeys = false;
            this.copyNameMenuItem.Size = new System.Drawing.Size(130, 22);
            this.copyNameMenuItem.Text = "&Copy Name";
            this.copyNameMenuItem.ToolTipText = "Copy name of this element to clipboard";
            // 
            // DBTreeView
            // 
            this.LineColor = System.Drawing.Color.Black;
            this.treeViewContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip treeViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyNameMenuItem;
    }
}
