using Presentation.Common;
using Presentation.Common.PresenterAbstractions;
using Presentation.Views;
using Models;

namespace Presentation.Presenters
{
    public class MainPresenter : BaseFormPresenter<IMainFormView>, IMainPresenter
    {
        public SelectionState MainState { get; set; }
        public MainPresenter(ApplicationController controller, IMainFormView view) 
            : base(controller, view)
        {
            Controller.RegisterFlowerViews(View.FlowersList);
            Init();
        }

        private void Init()
        {
            View.PlantAFlower += () => PlantAFlower();
            View.WaterFlowers += () => UpdateMainSelectionState(SelectionState.Watering);
            View.DeleteFlowers += () => UpdateMainSelectionState(SelectionState.Deleting);
            View.CancelSelection += () => UpdateMainSelectionState(SelectionState.Default);
        }
        private void PlantAFlower()
        {
            if (Mediator == null)
                Controller.RegisterMediator<MainPresenter>();

            if (Flower.Flowers.Count == 3)
            {
                View.ShowErrorMessage(ERROR_MESSAGE.NO_FREE_POTS);
                return;
            }

            Controller.Run<PlantAFlowerPresenter>();
        }

        public void UpdateMainSelectionState(SelectionState state)
        {
            MainState = state;
            Mediator?.Notify(this, state);

            if (state == SelectionState.Default)
                View.IsSelectionMode = false;
            else
                View.IsSelectionMode = true;
        }

        public override void Run()
        {
            View.Show();
        }
    }


}
