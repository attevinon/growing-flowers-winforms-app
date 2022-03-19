namespace UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPlantAFlower = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteFlowers = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWaterFlowers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFlower1 = new System.Windows.Forms.Panel();
            this.ctlFlower1 = new UI.FlowerViewControl();
            this.pnlFlower2 = new System.Windows.Forms.Panel();
            this.ctlFlower2 = new UI.FlowerViewControl();
            this.pnlFlower3 = new System.Windows.Forms.Panel();
            this.ctlFlower3 = new UI.FlowerViewControl();
            this.btnCancelSelection = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.pnlFlower1.SuspendLayout();
            this.pnlFlower2.SuspendLayout();
            this.pnlFlower3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuHelp});
            this.menuStrip.Name = "menuStrip";
            // 
            // mnuMain
            // 
            resources.ApplyResources(this.mnuMain, "mnuMain");
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPlantAFlower,
            this.itemDeleteFlowers,
            this.itemWaterFlowers});
            this.mnuMain.Name = "mnuMain";
            // 
            // itemPlantAFlower
            // 
            resources.ApplyResources(this.itemPlantAFlower, "itemPlantAFlower");
            this.itemPlantAFlower.Name = "itemPlantAFlower";
            // 
            // itemDeleteFlowers
            // 
            resources.ApplyResources(this.itemDeleteFlowers, "itemDeleteFlowers");
            this.itemDeleteFlowers.Name = "itemDeleteFlowers";
            // 
            // itemWaterFlowers
            // 
            resources.ApplyResources(this.itemWaterFlowers, "itemWaterFlowers");
            this.itemWaterFlowers.Name = "itemWaterFlowers";
            // 
            // mnuHelp
            // 
            resources.ApplyResources(this.mnuHelp, "mnuHelp");
            this.mnuHelp.Name = "mnuHelp";
            // 
            // pnlFlower1
            // 
            resources.ApplyResources(this.pnlFlower1, "pnlFlower1");
            this.pnlFlower1.Controls.Add(this.ctlFlower1);
            this.pnlFlower1.Name = "pnlFlower1";
            // 
            // ctlFlower1
            // 
            resources.ApplyResources(this.ctlFlower1, "ctlFlower1");
            this.ctlFlower1.ActWithFlower = null;
            this.ctlFlower1.FlowerName = "";
            this.ctlFlower1.IsButtonEnabled = false;
            this.ctlFlower1.IsWatered = false;
            this.ctlFlower1.Name = "ctlFlower1";
            // 
            // pnlFlower2
            // 
            resources.ApplyResources(this.pnlFlower2, "pnlFlower2");
            this.pnlFlower2.Controls.Add(this.ctlFlower2);
            this.pnlFlower2.Name = "pnlFlower2";
            // 
            // ctlFlower2
            // 
            resources.ApplyResources(this.ctlFlower2, "ctlFlower2");
            this.ctlFlower2.ActWithFlower = null;
            this.ctlFlower2.FlowerName = "";
            this.ctlFlower2.IsButtonEnabled = false;
            this.ctlFlower2.IsWatered = false;
            this.ctlFlower2.Name = "ctlFlower2";
            // 
            // pnlFlower3
            // 
            resources.ApplyResources(this.pnlFlower3, "pnlFlower3");
            this.pnlFlower3.Controls.Add(this.ctlFlower3);
            this.pnlFlower3.Name = "pnlFlower3";
            // 
            // ctlFlower3
            // 
            resources.ApplyResources(this.ctlFlower3, "ctlFlower3");
            this.ctlFlower3.ActWithFlower = null;
            this.ctlFlower3.FlowerName = "";
            this.ctlFlower3.IsButtonEnabled = false;
            this.ctlFlower3.IsWatered = false;
            this.ctlFlower3.Name = "ctlFlower3";
            // 
            // btnCancelSelection
            // 
            resources.ApplyResources(this.btnCancelSelection, "btnCancelSelection");
            this.btnCancelSelection.Name = "btnCancelSelection";
            this.btnCancelSelection.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCancelSelection);
            this.Controls.Add(this.pnlFlower3);
            this.Controls.Add(this.pnlFlower2);
            this.Controls.Add(this.pnlFlower1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlFlower1.ResumeLayout(false);
            this.pnlFlower2.ResumeLayout(false);
            this.pnlFlower3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem itemPlantAFlower;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Panel pnlFlower1;
        private System.Windows.Forms.Panel pnlFlower2;
        private System.Windows.Forms.Panel pnlFlower3;
        private System.Windows.Forms.Button btnCancelSelection;
        private FlowerViewControl ctlFlower1;
        private FlowerViewControl ctlFlower2;
        private FlowerViewControl ctlFlower3;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteFlowers;
        private System.Windows.Forms.ToolStripMenuItem itemWaterFlowers;
    }
}

