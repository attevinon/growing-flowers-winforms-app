using Presentation.Views;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPLantAFlower : Form, IPlantAFlowerFormView
    {
        public FormPLantAFlower()
        {
            InitializeComponent();

            btnDone.Click += (sender, e) => Invoke(PlantAFlower);

            cboColors.SelectedValueChanged += (sender, e) => SelectedColor = cboColors.SelectedIndex;
            txtName.TextChanged += (sender, e) => FlowerName = txtName.Text;
            FormClosed += (sender, e) => Dispose();
        }

        public Action PlantAFlower { get; set; }
        public string FlowerName { get; set; }
        public Array Colors { get; set; }
        public int SelectedColor { get; set; }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        private void FormPLantAFlower_Load(object sender, EventArgs e)
        {
            cboColors.DataSource = Colors;
        }

        public new void Show()
        {
            ShowDialog();
        }
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
