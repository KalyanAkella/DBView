namespace DBView.Dialogs.DBDialogs
{
    partial class OracleDBDialog
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
            this.cdUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cdServerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cdServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.cdConnNameTextBox = new System.Windows.Forms.TextBox();
            this.cdConnNameLabel = new System.Windows.Forms.Label();
            this.cdUserNameTextBox = new System.Windows.Forms.TextBox();
            this.cdPasswordLabel = new System.Windows.Forms.Label();
            this.cdUserNameLabel = new System.Windows.Forms.Label();
            this.cdPasswordTextBox = new System.Windows.Forms.TextBox();
            this.cdServiceNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cdPortLabel = new System.Windows.Forms.Label();
            this.cdHostNameTextBox = new System.Windows.Forms.TextBox();
            this.cdHostNameLabel = new System.Windows.Forms.Label();
            this.cdPortTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.cdServerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdUserName
            // 
            this.cdUserName.AutoSize = true;
            this.cdUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdUserName.Location = new System.Drawing.Point(3, 120);
            this.cdUserName.Name = "cdUserName";
            this.cdUserName.Size = new System.Drawing.Size(99, 40);
            this.cdUserName.TabIndex = 4;
            this.cdUserName.Text = "&User Name:";
            this.cdUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cdServerGroupBox
            // 
            this.cdServerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.cdServerGroupBox.Location = new System.Drawing.Point(4, 3);
            this.cdServerGroupBox.Name = "cdServerGroupBox";
            this.cdServerGroupBox.Size = new System.Drawing.Size(360, 155);
            this.cdServerGroupBox.TabIndex = 0;
            this.cdServerGroupBox.TabStop = false;
            this.cdServerGroupBox.Text = "Oracle Connection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.cdServiceNameTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cdConnNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdConnNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdUserNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cdPasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cdUserNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cdPasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cdServiceNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cdServiceNameTextBox
            // 
            this.cdServiceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdServiceNameTextBox.Location = new System.Drawing.Point(91, 81);
            this.cdServiceNameTextBox.Name = "cdServiceNameTextBox";
            this.cdServiceNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdServiceNameTextBox.TabIndex = 3;
            // 
            // cdConnNameTextBox
            // 
            this.cdConnNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdConnNameTextBox.Location = new System.Drawing.Point(91, 3);
            this.cdConnNameTextBox.Name = "cdConnNameTextBox";
            this.cdConnNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdConnNameTextBox.TabIndex = 0;
            // 
            // cdConnNameLabel
            // 
            this.cdConnNameLabel.AutoSize = true;
            this.cdConnNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdConnNameLabel.Location = new System.Drawing.Point(3, 0);
            this.cdConnNameLabel.Name = "cdConnNameLabel";
            this.cdConnNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdConnNameLabel.TabIndex = 12;
            this.cdConnNameLabel.Text = "&Connection:";
            this.cdConnNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdUserNameTextBox
            // 
            this.cdUserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdUserNameTextBox.Location = new System.Drawing.Point(91, 29);
            this.cdUserNameTextBox.Name = "cdUserNameTextBox";
            this.cdUserNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdUserNameTextBox.TabIndex = 1;
            // 
            // cdPasswordLabel
            // 
            this.cdPasswordLabel.AutoSize = true;
            this.cdPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdPasswordLabel.Location = new System.Drawing.Point(3, 52);
            this.cdPasswordLabel.Name = "cdPasswordLabel";
            this.cdPasswordLabel.Size = new System.Drawing.Size(82, 26);
            this.cdPasswordLabel.TabIndex = 10;
            this.cdPasswordLabel.Text = "&Password:";
            this.cdPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdUserNameLabel
            // 
            this.cdUserNameLabel.AutoSize = true;
            this.cdUserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdUserNameLabel.Location = new System.Drawing.Point(3, 26);
            this.cdUserNameLabel.Name = "cdUserNameLabel";
            this.cdUserNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdUserNameLabel.TabIndex = 9;
            this.cdUserNameLabel.Text = "&User Name:";
            this.cdUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdPasswordTextBox
            // 
            this.cdPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdPasswordTextBox.Location = new System.Drawing.Point(91, 55);
            this.cdPasswordTextBox.Name = "cdPasswordTextBox";
            this.cdPasswordTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdPasswordTextBox.TabIndex = 2;
            this.cdPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // cdServiceNameLabel
            // 
            this.cdServiceNameLabel.AutoSize = true;
            this.cdServiceNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdServiceNameLabel.Location = new System.Drawing.Point(3, 78);
            this.cdServiceNameLabel.Name = "cdServiceNameLabel";
            this.cdServiceNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdServiceNameLabel.TabIndex = 14;
            this.cdServiceNameLabel.Text = "&Service Name:";
            this.cdServiceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.cdPortLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cdHostNameTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cdHostNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cdPortTextBox, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 105);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 30);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // cdPortLabel
            // 
            this.cdPortLabel.AutoSize = true;
            this.cdPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdPortLabel.Location = new System.Drawing.Point(249, 0);
            this.cdPortLabel.Name = "cdPortLabel";
            this.cdPortLabel.Size = new System.Drawing.Size(29, 30);
            this.cdPortLabel.TabIndex = 17;
            this.cdPortLabel.Text = "&Port:";
            this.cdPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdHostNameTextBox
            // 
            this.cdHostNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdHostNameTextBox.Location = new System.Drawing.Point(73, 5);
            this.cdHostNameTextBox.Name = "cdHostNameTextBox";
            this.cdHostNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.cdHostNameTextBox.TabIndex = 0;
            this.cdHostNameTextBox.Text = "localhost";
            // 
            // cdHostNameLabel
            // 
            this.cdHostNameLabel.AutoSize = true;
            this.cdHostNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdHostNameLabel.Location = new System.Drawing.Point(3, 0);
            this.cdHostNameLabel.Name = "cdHostNameLabel";
            this.cdHostNameLabel.Size = new System.Drawing.Size(64, 30);
            this.cdHostNameLabel.TabIndex = 15;
            this.cdHostNameLabel.Text = "&Host Name:";
            this.cdHostNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdPortTextBox
            // 
            this.cdPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdPortTextBox.Location = new System.Drawing.Point(284, 5);
            this.cdPortTextBox.Name = "cdPortTextBox";
            this.cdPortTextBox.Size = new System.Drawing.Size(65, 20);
            this.cdPortTextBox.TabIndex = 1;
            this.cdPortTextBox.Text = "1521";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // OracleDBDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cdServerGroupBox);
            this.Name = "OracleDBDialog";
            this.Size = new System.Drawing.Size(368, 161);
            this.cdServerGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cdUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox cdServerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox cdPasswordTextBox;
        private System.Windows.Forms.Label cdUserNameLabel;
        private System.Windows.Forms.Label cdPasswordLabel;
        private System.Windows.Forms.TextBox cdUserNameTextBox;
        private System.Windows.Forms.TextBox cdConnNameTextBox;
        private System.Windows.Forms.Label cdConnNameLabel;
        private System.Windows.Forms.Label cdServiceNameLabel;
        private System.Windows.Forms.TextBox cdServiceNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label cdPortLabel;
        private System.Windows.Forms.TextBox cdHostNameTextBox;
        private System.Windows.Forms.Label cdHostNameLabel;
        private System.Windows.Forms.TextBox cdPortTextBox;

    }
}
