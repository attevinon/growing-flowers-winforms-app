

namespace Presentation.Common.PresenterAbstractions
{
    public interface IFlowerPresenter : IPresenter
    {
        /// <summary>
        /// Creates new flower presenter object and sets it's flower (context)
        /// </summary>
        /// <param name="flowerName"></param>
        void SetFlowerContext(string flowerName);

        //for connection with mediator
        void UpdateFlowerSelectionState(SelectionState sate);
    }
}
