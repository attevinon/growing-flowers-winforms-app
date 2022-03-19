using Presentation.Presenters;
using Presentation.Common.PresenterAbstractions;
using Presentation.Views;

namespace Presentation.Common
{
    internal interface IFlowerPresenterFactory<TFlowerPresenter> where TFlowerPresenter : IFlowerPresenter
    {
        TFlowerPresenter CreateFlowerPresenter(ApplicationController controller, IFlowerView view);
    }
    internal class FlowerPresenterFactory : IFlowerPresenterFactory<FlowerPresenter>
    {
        public FlowerPresenter CreateFlowerPresenter(ApplicationController controller, IFlowerView view)
        {
            return new FlowerPresenter(controller, view);
        }
    }
}
