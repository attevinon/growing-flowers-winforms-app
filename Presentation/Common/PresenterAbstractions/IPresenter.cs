

namespace Presentation.Common.PresenterAbstractions
{
    public interface IPresenter
    {
        void SetMediator(ISelectionStateMediator mediator);
        void Run();
    }
}
