namespace UI
{
    partial class FormPLantAFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPLantAFlower));
            this.pnlName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Controls.Add(this.txtName);
            resources.ApplyResources(this.pnlName, "pnlName");
            this.pnlName.Name = "pnlName";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.cboColors);
            this.pnlColor.Controls.Add(this.lblColor);
            resources.ApplyResources(this.pnlColor, "pnlColor");
            this.pnlColor.Name = "pnlColor";
            // 
            // cboColors
            // 
            this.cboColors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboColors.FormattingEnabled = true;
            resources.ApplyResources(this.cboColors, "cboColors");
            this.cboColors.Name = "cboColors";
            // 
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // btnDone
            // 
            resources.ApplyResources(this.btnDone, "btnDone");
            this.btnDone.Name = "btnDone";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // FormPLantAFlower
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPLantAFlower";
            this.Load += new System.EventHandler(this.FormPLantAFlower_Load);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnDone;
    }
}