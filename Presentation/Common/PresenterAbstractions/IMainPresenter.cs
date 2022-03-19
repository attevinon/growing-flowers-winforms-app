
namespace Presentation.Common.PresenterAbstractions
{
    public interface IMainPresenter : IPresenter
    {
        //for connection with mediator
        void UpdateMainSelectionState(SelectionState state);
    }
}
