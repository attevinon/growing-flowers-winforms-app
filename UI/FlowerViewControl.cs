using System;
using System.Drawing;
using System.Windows.Forms;
using Presentation.Views;
using UI.Properties;

namespace UI
{
    [Serializable]
    public partial class FlowerViewControl : UserControl, IFlowerView
    {
        private string flowerName;
        static private int i = 1;
        private string imageName;

        public FlowerViewControl()
        {
            InitializeComponent();
            btnSelectFlower.Click += (sender, e) => InvokeAction(ActWithFlower);
            Id = i;
            i++;
        }

        public int Id { get; }
        public string ImageName
        {
          private get => imageName;
          set 
            {
                imageName = value;
                picFlower.Image = picFlower.Image = Resources.ResourceManager.GetObject(imageName) as Image;
            } 
        }
        public bool IsWatered
        {
            get => false;
            set
            {
                if (value == true)
                    picFlower.BackgroundImage = Resources.pot_wet;
                else
                    picFlower.BackgroundImage = Resources.pot_dry;
            } 
        }
        public bool IsButtonEnabled
        {
            get => false;
            set => btnSelectFlower.Enabled = btnSelectFlower.Visible = value;
        }
        public string FlowerName
        {
            get => flowerName ?? "";
            set
            {
                lblName.Text = flowerName = value;
                lblName.Visible = true;
            }
        }
        public Action ActWithFlower { get; set; }
        private void InvokeAction(Action action)
        {
            if (action != null) action();
        }

        public void RefreshAfterDeleting()
        {
            picFlower.Image = null;
            FlowerName = null;
            ActWithFlower = null;
            IsWatered = false;

            this.Refresh();
        }
    }
}
