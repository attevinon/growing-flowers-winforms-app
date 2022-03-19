using Presentation.Views;


namespace Presentation.Common.PresenterAbstractions
{
    public abstract class BasePresenter<TView> : IPresenter where TView : IView
    {
        protected ISelectionStateMediator Mediator { get; private set; }
        protected TView View { get; private set; }
        protected ApplicationController Controller { get; private set; }

        public BasePresenter(ApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run();
        public void SetMediator(ISelectionStateMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
