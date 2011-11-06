namespace DBView.Controls
{
    partial class QueryBoxControl
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
            this.findPanel = new DBView.Controls.FindPanel();
            this.autoCompleteDropDown = new DBView.Controls.AutoCompleteDropDown();
            this.findPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // findPanel
            // 
            this.findPanel.BackColor = System.Drawing.Color.LightGray;
            this.findPanel.Location = new System.Drawing.Point(0, 0);
            this.findPanel.Name = "findPanel";
            this.findPanel.Size = new System.Drawing.Size(200, 100);
            this.findPanel.TabIndex = 1;
            // 
            // autoCompleteDropDown
            // 
            this.autoCompleteDropDown.Location = new System.Drawing.Point(0, 0);
            this.autoCompleteDropDown.Name = "autoCompleteDropDown";
            this.autoCompleteDropDown.Size = new System.Drawing.Size(120, 95);
            this.autoCompleteDropDown.TabIndex = 0;
            // 
            // QueryBoxControl
            // 
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "";
            this.Size = new System.Drawing.Size(449, 120);
            this.TabIndex = 0;
            this.Text = "";
            this.WordWrap = false;
            this.Controls.Add(this.autoCompleteDropDown);
            this.Controls.Add(this.findPanel);
            this.findPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DBView.Controls.AutoCompleteDropDown autoCompleteDropDown;
        private DBView.Controls.FindPanel findPanel;
    }
}
