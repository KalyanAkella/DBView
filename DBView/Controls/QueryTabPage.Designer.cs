using System.Windows.Forms;
using DBView.DB.Provider;

namespace DBView.Controls
{
    partial class QueryTabPage
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
        private void InitializeComponent(IDBViewProvider dbViewProvider)
        {
            this.querySplitContainer = new System.Windows.Forms.SplitContainer();
            this.queryPageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.queryBox = new DBView.Controls.QueryBoxControl(dbViewProvider);
            this.queryStatusLabel = new System.Windows.Forms.Label();
            this.queryDataGrid = new System.Windows.Forms.DataGridView();
            this.querySplitContainer.Panel1.SuspendLayout();
            this.querySplitContainer.Panel2.SuspendLayout();
            this.querySplitContainer.SuspendLayout();
            this.queryPageSplitContainer.Panel1.SuspendLayout();
            this.queryPageSplitContainer.Panel2.SuspendLayout();
            this.queryPageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // querySplitContainer
            // 
            this.querySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySplitContainer.Location = new System.Drawing.Point(3, 3);
            this.querySplitContainer.Name = "querySplitContainer";
            this.querySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // querySplitContainer.Panel1
            // 
            this.querySplitContainer.Panel1.Controls.Add(this.queryPageSplitContainer);
            // 
            // querySplitContainer.Panel2
            // 
            this.querySplitContainer.Panel2.Controls.Add(this.queryDataGrid);
            this.querySplitContainer.Size = new System.Drawing.Size(449, 361);
            this.querySplitContainer.SplitterDistance = 149;
            this.querySplitContainer.TabIndex = 0;
            this.querySplitContainer.TabStop = false;
            // 
            // queryPageSplitContainer
            // 
            this.queryPageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryPageSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.queryPageSplitContainer.IsSplitterFixed = true;
            this.queryPageSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.queryPageSplitContainer.Name = "queryPageSplitContainer";
            this.queryPageSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // queryPageSplitContainer.Panel1
            // 
            this.queryPageSplitContainer.Panel1.Controls.Add(this.queryBox);
            // 
            // queryPageSplitContainer.Panel2
            // 
            this.queryPageSplitContainer.Panel2.Controls.Add(this.queryStatusLabel);
            this.queryPageSplitContainer.Size = new System.Drawing.Size(449, 149);
            this.queryPageSplitContainer.SplitterDistance = 120;
            this.queryPageSplitContainer.TabIndex = 0;
            this.queryPageSplitContainer.TabStop = false;
            // 
            // queryStatusLabel
            // 
            this.queryStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queryStatusLabel.AutoSize = true;
            this.queryStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.queryStatusLabel.Name = "queryStatusLabel";
            this.queryStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.queryStatusLabel.TabIndex = 0;
            // 
            // queryDataGrid
            // 
            this.queryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.queryDataGrid.Name = "queryDataGrid";
            this.queryDataGrid.Size = new System.Drawing.Size(449, 208);
            this.queryDataGrid.TabIndex = 0;
            this.queryDataGrid.TabStop = false;
            this.queryDataGrid.AllowUserToAddRows = false;
            this.queryDataGrid.AllowUserToDeleteRows = false;
            this.queryDataGrid.AllowUserToResizeRows = false;
            this.queryDataGrid.AllowUserToOrderColumns = true;
            // 
            // QueryTabPage
            // 
            this.Controls.Add(this.querySplitContainer);
            this.Location = new System.Drawing.Point(4, 22);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(455, 367);
            this.TabIndex = 1;
            this.UseVisualStyleBackColor = true;
            this.querySplitContainer.Panel1.ResumeLayout(false);
            this.querySplitContainer.Panel2.ResumeLayout(false);
            this.querySplitContainer.ResumeLayout(false);
            this.queryPageSplitContainer.Panel1.ResumeLayout(false);
            this.queryPageSplitContainer.Panel2.ResumeLayout(false);
            this.queryPageSplitContainer.Panel2.PerformLayout();
            this.queryPageSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer querySplitContainer;
        private QueryBoxControl queryBox;
        private DataGridView queryDataGrid;
        private SplitContainer queryPageSplitContainer;
        private Label queryStatusLabel;
    }
}
