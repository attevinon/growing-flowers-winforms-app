using Presentation.Views;


namespace Presentation.Common.PresenterAbstractions
{
    public class BaseFormPresenter<TFormView> : BasePresenter<TFormView> where TFormView : IFormView
    {
        public BaseFormPresenter(ApplicationController controller, TFormView view)
            : base(controller, view) { }

        public override void Run()
        {
            View.Show();
        }
    }
}
