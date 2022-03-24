using Presentation.Views;
using System.Windows.Forms;
using System.Globalization;
using UI.Properties;

namespace UI
{
    public partial class FormHelp : Form, IHelpView
    {
        public FormHelp()
        {
            InitializeComponent();

            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ru")
                lblHelp.Text = Resources.str_help_ru;

            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "be")
                lblHelp.Text = Resources.str_help_by;

            else
                lblHelp.Text = Resources.str_help_eng;
        }
    }
}
