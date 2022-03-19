using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        private void InvokeActionMain(Action action)
        {
            if (action != null) action();
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void GetHelp()
        {
            var text = (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ru") ? strRu : strEng;

            MessageBox.Show(text, "Help", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }

        string strEng = "Welcome to Growing Flowers app!" + Environment.NewLine
            + "Here you can... um... growing flowers I guess?" + Environment.NewLine
            + "Anyway at first you should plant a flower (Menu -> Plant new flower)!" + Environment.NewLine
            + "The next step is to water your flower so it will start to grow (Menu -> Water the flower)! " +
            "There're different kinds of plants and some of them must be watered multiply times. " +
            "(you have to learn it out on your own experience...)" + Environment.NewLine
            + "You can have only 3 flowers simultaneously. If you'd like to plant the 4th+ flower " +
            "you have to delete one of those that already exists (Menu -> Delete flowers)" + Environment.NewLine
            + Environment.NewLine
            + "By @attevinon <3";

        string strRu = "Добро пожаловать в приложение Растим цветочки! " + Environment.NewLine
            + "Здесь Вы.. Эм... Можете растить цветы?.. наверное? " + Environment.NewLine
            + "В любом случае для начала Вам нужно посадить свой первый цветок (Меню -> Посадить цветочек). " + Environment.NewLine
            + "Затем цветок следует полить, чтобы он вырос (Меню -> Полить цветы). " +
            "Разным видам цветов необходимо разное количесвто поливов для того, чтобы они подросли " +
            "(Вам придётся изучить это самостоятельно...)! " + Environment.NewLine
            + "Одновременно у Вас может быть только 3 растения. " +
            "Если Вы хотите посадить четвёртый+ цветок, то для Вам нужно удалить один из имеющихся (Меню -> Удалить цветы)" + Environment.NewLine
            + Environment.NewLine
            + "By @attevinon <3";
    }
}
