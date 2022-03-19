using LightInject;
using Presentation.Views;
using System.Collections.Generic;
using Presentation.Common.PresenterAbstractions;

namespace Presentation.Common
{
    /// <summary>
    /// Takes all views and presenters together, provides communication between them.
    /// Kind of mediator pattern I guess. Realized via IoC.
    /// </summary>
    public class ApplicationController
    {
        ServiceContainer container;

        public ApplicationController(ServiceContainer container)
        {
            this.container = container;

            container.RegisterInstance<ApplicationController>(this);
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            var presenter = container.GetInstance<TPresenter>();
            presenter.Run();
        }
        internal void RegisterMediator<TMainPresenter>() where TMainPresenter : class, IMainPresenter
        {
            var presenter = container.GetInstance<TMainPresenter>();
            if (presenter != null)
                container.RegisterInstance(new SelectionStateMediator(presenter)); //auto adds new PerContainerLifetime()
        }

        internal void RegisterFlowerViews<TFLowerView>(IEnumerable<TFLowerView> views) where TFLowerView : IFlowerView
        {
            foreach (var view in views)
            {
                container.RegisterInstance(view, $"{view.Id}");
            }
        }

        /// <summary>
        /// Creates new flower presenter object connected with empty flower view
        /// </summary>
        /// <typeparam name="TFlowerPresenter"></typeparam>
        /// <param name="name"></param>
        internal void RegisterFlowerPresenter<TFlowerPresenter>(string name) where TFlowerPresenter : class, IFlowerPresenter
        {
            var view = CheckFlowers();

            var factory = new FlowerPresenterFactory();
            var presenter = factory.CreateFlowerPresenter(this, view) as TFlowerPresenter;

            container.RegisterInstance(presenter, $"{view.Id}");

            if(container.CanGetInstance(typeof(TFlowerPresenter), $"{view.Id}"))
            {
                presenter.SetFlowerContext(name);
                container.TryGetInstance<SelectionStateMediator>()?.AddFLowerPresenter(presenter);
                presenter.Run();
            }
        }

        /// <summary>
        /// Returns flower view if it's empty (doesn't present any flower)
        /// </summary>
        /// <returns></returns>
        private IFlowerView CheckFlowers()
        {
            var flowerViews = container.GetAllInstances<IFlowerView>();
            foreach (var view in flowerViews)
            {
                if (string.IsNullOrEmpty(view.FlowerName))
                    return view;
            }

            return null;
        }
    }
}
