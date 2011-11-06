using System.Drawing;
using System.Windows.Forms;

namespace DBView.Controls
{
    partial class FindPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.findTextBox = new DBView.Controls.FindTextBox();
            this.matchCase = new System.Windows.Forms.CheckBox();
            this.wholeWord = new System.Windows.Forms.CheckBox();
            this.findStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.findTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.matchCase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wholeWord, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.findStatus, 3, 0);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // findTextBox
            // 
            this.findTextBox.Dock = DockStyle.Fill;
            this.findTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(3, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(342, 22);
            this.findTextBox.TabIndex = 0;
            // 
            // matchCase
            // 
            this.matchCase.AutoSize = true;
            this.matchCase.Dock = DockStyle.Fill;
            this.matchCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.matchCase.Location = new System.Drawing.Point(351, 3);
            this.matchCase.Name = "matchCase";
            this.matchCase.Size = new System.Drawing.Size(168, 23);
            this.matchCase.TabIndex = 1;
            this.matchCase.Text = "Match &case";
            this.matchCase.UseVisualStyleBackColor = true;
            // 
            // wholeWord
            // 
            this.wholeWord.AutoSize = true;
            this.wholeWord.Dock = DockStyle.Fill;
            this.wholeWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.wholeWord.Location = new System.Drawing.Point(525, 3);
            this.wholeWord.Name = "wholeWord";
            this.wholeWord.Size = new System.Drawing.Size(168, 23);
            this.wholeWord.TabIndex = 2;
            this.wholeWord.Text = "Match &whole word";
            this.wholeWord.UseVisualStyleBackColor = true;
            // 
            // findStatus
            // 
            this.findStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            this.findStatus.AutoSize = true;
            this.findStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.findStatus.Location = new System.Drawing.Point(699, 8);
            this.findStatus.Name = "findStatus";
            this.findStatus.Size = new System.Drawing.Size(169, 13);
            this.findStatus.TabIndex = 3;
            // 
            // FindPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FindPanel";
            this.Size = new System.Drawing.Size(871, 29);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FindTextBox findTextBox;
        private System.Windows.Forms.CheckBox matchCase;
        private System.Windows.Forms.CheckBox wholeWord;
        private System.Windows.Forms.Label findStatus;
    }
}
