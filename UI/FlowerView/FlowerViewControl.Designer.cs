namespace UI
{
    partial class FlowerViewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowerViewControl));
            this.lblName = new System.Windows.Forms.Label();
            this.btnSelectFlower = new System.Windows.Forms.Button();
            this.picFlower = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // btnSelectFlower
            // 
            resources.ApplyResources(this.btnSelectFlower, "btnSelectFlower");
            this.btnSelectFlower.Name = "btnSelectFlower";
            this.btnSelectFlower.UseVisualStyleBackColor = true;
            // 
            // picFlower
            // 
            resources.ApplyResources(this.picFlower, "picFlower");
            this.picFlower.BackColor = System.Drawing.Color.Transparent;
            this.picFlower.BackgroundImage = global::UI.Properties.Resources.pot_dry;
            this.picFlower.Name = "picFlower";
            this.picFlower.TabStop = false;
            // 
            // FlowerViewControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.picFlower);
            this.Controls.Add(this.btnSelectFlower);
            this.Controls.Add(this.lblName);
            this.Name = "FlowerViewControl";
            ((System.ComponentModel.ISupportInitialize)(this.picFlower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSelectFlower;
        private System.Windows.Forms.PictureBox picFlower;
    }
}
