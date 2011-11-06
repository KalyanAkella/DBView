namespace DBView.Dialogs.DBDialogs
{
    partial class SqlServerDBDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cdPasswordTextBox = new System.Windows.Forms.TextBox();
            this.cdPasswordLabel = new System.Windows.Forms.Label();
            this.cdUserNameTextBox = new System.Windows.Forms.TextBox();
            this.cdConnNameLabel = new System.Windows.Forms.Label();
            this.cdConnNameTextBox = new System.Windows.Forms.TextBox();
            this.cdServerNameLabel = new System.Windows.Forms.Label();
            this.cdServerNameTextBox = new System.Windows.Forms.TextBox();
            this.cdDatabaseLabel = new System.Windows.Forms.Label();
            this.cdDatabaseTextBox = new System.Windows.Forms.TextBox();
            this.cdAuthLabel = new System.Windows.Forms.Label();
            this.cdAuthTypeCombo = new System.Windows.Forms.ComboBox();
            this.cdUserNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SqlServer Connection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.cdPasswordTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cdPasswordLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cdUserNameTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cdConnNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdConnNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cdServerNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cdServerNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cdDatabaseLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cdDatabaseTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cdAuthLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cdAuthTypeCombo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cdUserNameLabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 161);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cdPasswordTextBox
            // 
            this.cdPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdPasswordTextBox.Enabled = false;
            this.cdPasswordTextBox.Location = new System.Drawing.Point(91, 136);
            this.cdPasswordTextBox.Name = "cdPasswordTextBox";
            this.cdPasswordTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdPasswordTextBox.TabIndex = 5;
            // 
            // cdPasswordLabel
            // 
            this.cdPasswordLabel.AutoSize = true;
            this.cdPasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdPasswordLabel.Location = new System.Drawing.Point(3, 131);
            this.cdPasswordLabel.Name = "cdPasswordLabel";
            this.cdPasswordLabel.Size = new System.Drawing.Size(82, 30);
            this.cdPasswordLabel.TabIndex = 19;
            this.cdPasswordLabel.Text = "&Password:";
            this.cdPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdUserNameTextBox
            // 
            this.cdUserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdUserNameTextBox.Enabled = false;
            this.cdUserNameTextBox.Location = new System.Drawing.Point(91, 108);
            this.cdUserNameTextBox.Name = "cdUserNameTextBox";
            this.cdUserNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdUserNameTextBox.TabIndex = 4;
            // 
            // cdConnNameLabel
            // 
            this.cdConnNameLabel.AutoSize = true;
            this.cdConnNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdConnNameLabel.Location = new System.Drawing.Point(3, 0);
            this.cdConnNameLabel.Name = "cdConnNameLabel";
            this.cdConnNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdConnNameLabel.TabIndex = 14;
            this.cdConnNameLabel.Text = "&Connection:";
            this.cdConnNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdConnNameTextBox
            // 
            this.cdConnNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdConnNameTextBox.Location = new System.Drawing.Point(91, 3);
            this.cdConnNameTextBox.Name = "cdConnNameTextBox";
            this.cdConnNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdConnNameTextBox.TabIndex = 0;
            // 
            // cdServerNameLabel
            // 
            this.cdServerNameLabel.AutoSize = true;
            this.cdServerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdServerNameLabel.Location = new System.Drawing.Point(3, 26);
            this.cdServerNameLabel.Name = "cdServerNameLabel";
            this.cdServerNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdServerNameLabel.TabIndex = 12;
            this.cdServerNameLabel.Text = "&Server Name:";
            this.cdServerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdServerNameTextBox
            // 
            this.cdServerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdServerNameTextBox.Location = new System.Drawing.Point(91, 29);
            this.cdServerNameTextBox.Name = "cdServerNameTextBox";
            this.cdServerNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdServerNameTextBox.TabIndex = 1;
            // 
            // cdDatabaseLabel
            // 
            this.cdDatabaseLabel.AutoSize = true;
            this.cdDatabaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdDatabaseLabel.Location = new System.Drawing.Point(3, 52);
            this.cdDatabaseLabel.Name = "cdDatabaseLabel";
            this.cdDatabaseLabel.Size = new System.Drawing.Size(82, 26);
            this.cdDatabaseLabel.TabIndex = 10;
            this.cdDatabaseLabel.Text = "&Database:";
            this.cdDatabaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdDatabaseTextBox
            // 
            this.cdDatabaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdDatabaseTextBox.Location = new System.Drawing.Point(91, 55);
            this.cdDatabaseTextBox.Name = "cdDatabaseTextBox";
            this.cdDatabaseTextBox.Size = new System.Drawing.Size(260, 20);
            this.cdDatabaseTextBox.TabIndex = 2;
            // 
            // cdAuthLabel
            // 
            this.cdAuthLabel.AutoSize = true;
            this.cdAuthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdAuthLabel.Location = new System.Drawing.Point(3, 78);
            this.cdAuthLabel.Name = "cdAuthLabel";
            this.cdAuthLabel.Size = new System.Drawing.Size(82, 27);
            this.cdAuthLabel.TabIndex = 15;
            this.cdAuthLabel.Text = "&Authentication:";
            this.cdAuthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cdAuthTypeCombo
            // 
            this.cdAuthTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cdAuthTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdAuthTypeCombo.FormattingEnabled = true;
            this.cdAuthTypeCombo.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cdAuthTypeCombo.Location = new System.Drawing.Point(91, 81);
            this.cdAuthTypeCombo.Name = "cdAuthTypeCombo";
            this.cdAuthTypeCombo.Size = new System.Drawing.Size(260, 21);
            this.cdAuthTypeCombo.TabIndex = 3;
            // 
            // cdUserNameLabel
            // 
            this.cdUserNameLabel.AutoSize = true;
            this.cdUserNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdUserNameLabel.Location = new System.Drawing.Point(3, 105);
            this.cdUserNameLabel.Name = "cdUserNameLabel";
            this.cdUserNameLabel.Size = new System.Drawing.Size(82, 26);
            this.cdUserNameLabel.TabIndex = 17;
            this.cdUserNameLabel.Text = "&Username:";
            this.cdUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SqlServerDBDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SqlServerDBDialog";
            this.Size = new System.Drawing.Size(368, 187);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cdDatabaseLabel;
        private System.Windows.Forms.TextBox cdDatabaseTextBox;
        private System.Windows.Forms.TextBox cdServerNameTextBox;
        private System.Windows.Forms.Label cdServerNameLabel;
        private System.Windows.Forms.Label cdConnNameLabel;
        private System.Windows.Forms.TextBox cdConnNameTextBox;
        private System.Windows.Forms.Label cdAuthLabel;
        private System.Windows.Forms.ComboBox cdAuthTypeCombo;
        private System.Windows.Forms.Label cdUserNameLabel;
        private System.Windows.Forms.TextBox cdUserNameTextBox;
        private System.Windows.Forms.TextBox cdPasswordTextBox;
        private System.Windows.Forms.Label cdPasswordLabel;
    }
}
