using System.Collections.Generic;
using Presentation.Common.PresenterAbstractions;

namespace Presentation.Common
{
    public interface ISelectionStateMediator
    {
        void Notify(object sender, SelectionState state);
        void AddFLowerPresenter(IFlowerPresenter flowerPresenter);
        void RemoveFlowerPresenter(IFlowerPresenter flowerPresenter);

    }

    /// <summary>
    /// Provides connection between flower-views' selection state and main-view's selection state
    /// </summary>
    public class SelectionStateMediator : ISelectionStateMediator
    {
        private readonly IMainPresenter mainPresenter;
        private readonly List<IFlowerPresenter> flowerPresenters;

        public SelectionStateMediator(IMainPresenter mainPresenter)
        {
            this.mainPresenter = mainPresenter;
            mainPresenter.SetMediator(this);
            flowerPresenters = new List<IFlowerPresenter>(4);
        }

        public void Notify(object sender, SelectionState state)
        {
            if(sender == mainPresenter)
            {
                foreach (var flowerPresenter in flowerPresenters)
                {
                    flowerPresenter.UpdateFlowerSelectionState(state);
                }
                return;
            }

            ///uses when one of flowers was selected
            if (sender is IFlowerPresenter)
            {
                mainPresenter.UpdateMainSelectionState(state);
            }
        }

        public void AddFLowerPresenter(IFlowerPresenter flowerPresenter)
        {
            flowerPresenters.Add(flowerPresenter);
            flowerPresenter.SetMediator(this);
        }

        public void RemoveFlowerPresenter(IFlowerPresenter flowerPresenter)
        {
            flowerPresenters.Remove(flowerPresenter);
        }
    }
}
