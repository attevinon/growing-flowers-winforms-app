using Presentation.Common;
using Presentation.Common.PresenterAbstractions;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class HelpPresenter : BaseFormPresenter<IHelpView>
    {

        public HelpPresenter(ApplicationController controller, IHelpView view) : base(controller, view)
        {
        }
    }
}
