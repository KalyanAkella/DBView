using System.Windows.Forms;

namespace DBView.Dialogs
{
    partial class TreeViewFindDialog
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
            this.findWhatLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.viewsCheckBox = new System.Windows.Forms.CheckBox();
            this.pkgsCheckBox = new System.Windows.Forms.CheckBox();
            this.tablesCheckBox = new System.Windows.Forms.CheckBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.matchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.findGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findWhatLabel
            // 
            this.findWhatLabel.AutoSize = true;
            this.findWhatLabel.Location = new System.Drawing.Point(13, 13);
            this.findWhatLabel.Name = "findWhatLabel";
            this.findWhatLabel.Size = new System.Drawing.Size(56, 13);
            this.findWhatLabel.TabIndex = 0;
            this.findWhatLabel.Text = "Fi&nd what:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(86, 10);
            this.findTextBox.MaxLength = 256;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(238, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.viewsCheckBox);
            this.findGroupBox.Controls.Add(this.pkgsCheckBox);
            this.findGroupBox.Controls.Add(this.tablesCheckBox);
            this.findGroupBox.Location = new System.Drawing.Point(16, 39);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(308, 89);
            this.findGroupBox.TabIndex = 2;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Look in";
            // 
            // viewsCheckBox
            // 
            this.viewsCheckBox.AutoSize = true;
            this.viewsCheckBox.Location = new System.Drawing.Point(6, 67);
            this.viewsCheckBox.Name = "viewsCheckBox";
            this.viewsCheckBox.Size = new System.Drawing.Size(54, 17);
            this.viewsCheckBox.TabIndex = 2;
            this.viewsCheckBox.Text = "&Views";
            this.viewsCheckBox.UseVisualStyleBackColor = true;
            // 
            // pkgsCheckBox
            // 
            this.pkgsCheckBox.AutoSize = true;
            this.pkgsCheckBox.Location = new System.Drawing.Point(6, 43);
            this.pkgsCheckBox.Name = "pkgsCheckBox";
            this.pkgsCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pkgsCheckBox.TabIndex = 1;
            this.pkgsCheckBox.Text = "&Packages";
            this.pkgsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tablesCheckBox
            // 
            this.tablesCheckBox.AutoSize = true;
            this.tablesCheckBox.Location = new System.Drawing.Point(6, 19);
            this.tablesCheckBox.Name = "tablesCheckBox";
            this.tablesCheckBox.Size = new System.Drawing.Size(58, 17);
            this.tablesCheckBox.TabIndex = 0;
            this.tablesCheckBox.Text = "&Tables";
            this.tablesCheckBox.UseVisualStyleBackColor = true;
            // 
            // findNextButton
            // 
            this.findNextButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findNextButton.Enabled = false;
            this.findNextButton.Location = new System.Drawing.Point(341, 10);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(75, 23);
            this.findNextButton.TabIndex = 4;
            this.findNextButton.Text = "&Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(341, 40);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // matchWholeWordCheckBox
            // 
            this.matchWholeWordCheckBox.AutoSize = true;
            this.matchWholeWordCheckBox.Location = new System.Drawing.Point(16, 134);
            this.matchWholeWordCheckBox.Name = "matchWholeWordCheckBox";
            this.matchWholeWordCheckBox.Size = new System.Drawing.Size(137, 17);
            this.matchWholeWordCheckBox.TabIndex = 3;
            this.matchWholeWordCheckBox.Text = "Match &whole string only";
            this.matchWholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(233, 135);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.matchCaseCheckBox.TabIndex = 6;
            this.matchCaseCheckBox.Text = "Match &case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // TreeViewFindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(428, 156);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.matchWholeWordCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.findGroupBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findWhatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeViewFindDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findWhatLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.CheckBox viewsCheckBox;
        private System.Windows.Forms.CheckBox pkgsCheckBox;
        private System.Windows.Forms.CheckBox tablesCheckBox;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox matchWholeWordCheckBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
    }
}