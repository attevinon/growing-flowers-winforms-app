using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMain : Form, IMainFormView
    {

        protected ApplicationContext context;
        public FormMain(ApplicationContext context)
        {
            this.context = context;

            InitializeComponent();

            FlowersList = new List<IFlowerView>
            {
                ctlFlower1,
                ctlFlower2,
                ctlFlower3
            };

            mnuHelp.Click += (sender, e) => GetHelp();

            itemPlantAFlower.Click += (sender, e) => InvokeActionMain(PlantAFlower);

            itemWaterFlowers.Click += (sender, e) => InvokeActionMain(WaterFlowers);
            itemDeleteFlowers.Click += (sender, e) => InvokeActionMain(DeleteFlowers);
            btnCancelSelection.Click += (sender, e) => InvokeActionMain(CancelSelection);
        }

        public List<IFlowerView> FlowersList { get; }
        public bool IsSelectionMode { get => default; set => btnCancelSelection.Visible = value; }
        public Action CancelSelection { get; set; }
        public Action PlantAFlower { get; set; }
        public Action WaterFlowers { get; set; }
        public Action DeleteFlowers { get; set; }
        public Action GetHelp { get; set; }

        private void InvokeActionMain(Action action)
        {
            if (action != null) action();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }
    }
}
