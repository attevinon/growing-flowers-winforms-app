using System;
using LightInject;
using System.Windows.Forms;
using Presentation.Common;
using Presentation.Presenters;
using Presentation.Views;

namespace UI
{
    internal static class Program
    {
        public static readonly ApplicationContext Context = new ApplicationContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceContainer container = new ServiceContainer();

            container.Register<IMainFormView, FormMain>();
            container.Register<IPlantAFlowerFormView, FormPLantAFlower>();
            container.Register<IHelpView, FormHelp>();

            container.Register<MainPresenter>(new PerContainerLifetime());
            container.Register<HelpPresenter>(new PerContainerLifetime());
            container.Register<PlantAFlowerPresenter>();

            container.Register<ISelectionStateMediator, SelectionStateMediator>(new PerContainerLifetime());

            container.RegisterInstance<ApplicationContext>(Context);

            ApplicationController controller = new ApplicationController(container);
            controller.Run<MainPresenter>();
        }
    }
}
