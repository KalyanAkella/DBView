namespace DBView.Controls
{
    partial class PaginatedDataGrid
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.paginationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.firstRow = new System.Windows.Forms.Button();
            this.previousRow = new System.Windows.Forms.Button();
            this.currentRow = new System.Windows.Forms.TextBox();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.nextRow = new System.Windows.Forms.Button();
            this.lastRow = new System.Windows.Forms.Button();
            this.newRow = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.paginationPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(491, 327);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // paginationPanel
            // 
            this.paginationPanel.ColumnCount = 3;
            this.paginationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paginationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.paginationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paginationPanel.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginationPanel.Location = new System.Drawing.Point(0, 0);
            this.paginationPanel.Margin = new System.Windows.Forms.Padding(1);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.RowCount = 1;
            this.paginationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paginationPanel.Size = new System.Drawing.Size(491, 30);
            this.paginationPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.firstRow);
            this.flowLayoutPanel1.Controls.Add(this.previousRow);
            this.flowLayoutPanel1.Controls.Add(this.currentRow);
            this.flowLayoutPanel1.Controls.Add(this.rowCountLabel);
            this.flowLayoutPanel1.Controls.Add(this.nextRow);
            this.flowLayoutPanel1.Controls.Add(this.lastRow);
            this.flowLayoutPanel1.Controls.Add(this.newRow);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(99, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // firstRow
            // 
            this.firstRow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRow.Location = new System.Drawing.Point(1, 1);
            this.firstRow.Margin = new System.Windows.Forms.Padding(1);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(35, 25);
            this.firstRow.TabIndex = 0;
            this.firstRow.Text = "<<";
            this.firstRow.UseVisualStyleBackColor = true;
            // 
            // previousRow
            // 
            this.previousRow.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousRow.Location = new System.Drawing.Point(38, 1);
            this.previousRow.Margin = new System.Windows.Forms.Padding(1);
            this.previousRow.Name = "previousRow";
            this.previousRow.Size = new System.Drawing.Size(35, 25);
            this.previousRow.TabIndex = 1;
            this.previousRow.Text = "<";
            this.previousRow.UseVisualStyleBackColor = true;
            // 
            // currentRow
            // 
            this.currentRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.currentRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentRow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRow.Location = new System.Drawing.Point(75, 1);
            this.currentRow.Margin = new System.Windows.Forms.Padding(1);
            this.currentRow.MaxLength = 3;
            this.currentRow.Name = "currentRow";
            this.currentRow.Size = new System.Drawing.Size(46, 23);
            this.currentRow.TabIndex = 2;
            this.currentRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rowCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowCountLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCountLabel.Location = new System.Drawing.Point(123, 1);
            this.rowCountLabel.Margin = new System.Windows.Forms.Padding(1);
            this.rowCountLabel.MaximumSize = new System.Drawing.Size(60, 25);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(56, 25);
            this.rowCountLabel.TabIndex = 3;
            this.rowCountLabel.Text = "/";
            this.rowCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextRow
            // 
            this.nextRow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRow.Location = new System.Drawing.Point(181, 1);
            this.nextRow.Margin = new System.Windows.Forms.Padding(1);
            this.nextRow.Name = "nextRow";
            this.nextRow.Size = new System.Drawing.Size(35, 25);
            this.nextRow.TabIndex = 4;
            this.nextRow.Text = ">";
            this.nextRow.UseVisualStyleBackColor = true;
            // 
            // lastRow
            // 
            this.lastRow.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastRow.Location = new System.Drawing.Point(218, 1);
            this.lastRow.Margin = new System.Windows.Forms.Padding(1);
            this.lastRow.Name = "lastRow";
            this.lastRow.Size = new System.Drawing.Size(35, 25);
            this.lastRow.TabIndex = 5;
            this.lastRow.Text = ">>";
            this.lastRow.UseVisualStyleBackColor = true;
            // 
            // newRow
            // 
            this.newRow.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRow.Location = new System.Drawing.Point(255, 1);
            this.newRow.Margin = new System.Windows.Forms.Padding(1);
            this.newRow.Name = "newRow";
            this.newRow.Size = new System.Drawing.Size(35, 25);
            this.newRow.TabIndex = 6;
            this.newRow.Text = ">*";
            this.newRow.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(491, 295);
            this.dataGridView.TabIndex = 0;
            // 
            // PaginatedDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PaginatedDataGrid";
            this.Size = new System.Drawing.Size(491, 327);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.paginationPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel paginationPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button firstRow;
        private System.Windows.Forms.Button previousRow;
        private System.Windows.Forms.TextBox currentRow;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.Button nextRow;
        private System.Windows.Forms.Button lastRow;
        private System.Windows.Forms.Button newRow;
    }
}
