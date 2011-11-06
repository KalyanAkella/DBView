namespace DBView.Dialogs
{
    partial class ConnectDialog
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
            this.cdStatusStrip = new System.Windows.Forms.StatusStrip();
            this.cdConnectStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dbServers = new System.Windows.Forms.TreeView();
            this.cdDialogPanel = new System.Windows.Forms.Panel();
            this.cdButtonPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cdCancelButton = new System.Windows.Forms.Button();
            this.cdConnectButton = new System.Windows.Forms.Button();
            this.cdTestButton = new System.Windows.Forms.Button();
            this.cdStatusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cdButtonPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdStatusStrip
            // 
            this.cdStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cdConnectStatusLabel});
            this.cdStatusStrip.Location = new System.Drawing.Point(0, 274);
            this.cdStatusStrip.Name = "cdStatusStrip";
            this.cdStatusStrip.Size = new System.Drawing.Size(566, 22);
            this.cdStatusStrip.SizingGrip = false;
            this.cdStatusStrip.TabIndex = 0;
            this.cdStatusStrip.Text = "Ready";
            // 
            // cdConnectStatusLabel
            // 
            this.cdConnectStatusLabel.Name = "cdConnectStatusLabel";
            this.cdConnectStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.cdConnectStatusLabel.Text = "Ready";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dbServers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cdDialogPanel);
            this.splitContainer1.Panel2.Controls.Add(this.cdButtonPanel);
            this.splitContainer1.Size = new System.Drawing.Size(566, 274);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dbServers
            // 
            this.dbServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbServers.Location = new System.Drawing.Point(0, 0);
            this.dbServers.Name = "dbServers";
            this.dbServers.Size = new System.Drawing.Size(178, 274);
            this.dbServers.TabIndex = 0;
            // 
            // cdDialogPanel
            // 
            this.cdDialogPanel.AutoScroll = true;
            this.cdDialogPanel.Location = new System.Drawing.Point(2, 3);
            this.cdDialogPanel.Name = "cdDialogPanel";
            this.cdDialogPanel.Size = new System.Drawing.Size(382, 222);
            this.cdDialogPanel.TabIndex = 0;
            // 
            // cdButtonPanel
            // 
            this.cdButtonPanel.Controls.Add(this.tableLayoutPanel1);
            this.cdButtonPanel.Location = new System.Drawing.Point(2, 231);
            this.cdButtonPanel.Name = "cdButtonPanel";
            this.cdButtonPanel.Size = new System.Drawing.Size(382, 41);
            this.cdButtonPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cdCancelButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdConnectButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdTestButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 41);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cdCancelButton
            // 
            this.cdCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cdCancelButton.Location = new System.Drawing.Point(257, 8);
            this.cdCancelButton.Name = "cdCancelButton";
            this.cdCancelButton.Size = new System.Drawing.Size(122, 24);
            this.cdCancelButton.TabIndex = 2;
            this.cdCancelButton.Text = "C&ancel";
            this.cdCancelButton.UseVisualStyleBackColor = true;
            // 
            // cdConnectButton
            // 
            this.cdConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdConnectButton.Enabled = false;
            this.cdConnectButton.Location = new System.Drawing.Point(130, 8);
            this.cdConnectButton.Name = "cdConnectButton";
            this.cdConnectButton.Size = new System.Drawing.Size(121, 24);
            this.cdConnectButton.TabIndex = 1;
            this.cdConnectButton.Text = "&Connect";
            this.cdConnectButton.UseVisualStyleBackColor = true;
            // 
            // cdTestButton
            // 
            this.cdTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdTestButton.Enabled = false;
            this.cdTestButton.Location = new System.Drawing.Point(3, 8);
            this.cdTestButton.Name = "cdTestButton";
            this.cdTestButton.Size = new System.Drawing.Size(121, 24);
            this.cdTestButton.TabIndex = 0;
            this.cdTestButton.Text = "&Test";
            this.cdTestButton.UseVisualStyleBackColor = true;
            // 
            // ConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cdCancelButton;
            this.ClientSize = new System.Drawing.Size(566, 296);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cdStatusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Connect to a database server";
            this.cdStatusStrip.ResumeLayout(false);
            this.cdStatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.cdButtonPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip cdStatusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView dbServers;
        private System.Windows.Forms.Panel cdButtonPanel;
        private System.Windows.Forms.Panel cdDialogPanel;
        private System.Windows.Forms.ToolStripStatusLabel cdConnectStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cdCancelButton;
        private System.Windows.Forms.Button cdConnectButton;
        private System.Windows.Forms.Button cdTestButton;

    }
}