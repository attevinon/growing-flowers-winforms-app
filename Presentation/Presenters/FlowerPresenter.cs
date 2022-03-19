using System;
using System.Threading.Tasks;
using Models;
using Presentation.Common;
using Presentation.Common.PresenterAbstractions;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class FlowerPresenter : BasePresenter<IFlowerView>, IFlowerPresenter
    {
        private string flowerName;

        public FlowerPresenter(ApplicationController controller, IFlowerView view) : base(controller, view)
        {
            View.ActWithFlower += () => ActWithFlower();
            State = SelectionState.Default;
        }
        private Flower Flower { get; set; }
        private SelectionState State { get; set; }
        private string FlowerName { get => flowerName; set => flowerName = View.FlowerName = value; }
        private bool IsWatered { set => View.IsWatered = value; }
        private string Color { get; set; }

        public override void Run()
        {
            View.FlowerName = FlowerName;
            UpdateGrowthStage(1);
        }

        private void ActWithFlower()
        {
            switch (State)
            {
                case SelectionState.Watering:
                    WaterTheFlower();
                    break;
                case SelectionState.Deleting:
                    DeleteTheFlower();
                    break;
            }

            Mediator?.Notify(this, SelectionState.Default);
        }

        private void UpdateGrowthStage(int stage)
        {
            View.ImageName = Color + $"_{stage}";
        }

        private async Task WaterTheFlower()
        {
            IsWatered = true;

            await Flower.WateringAsync();

            IsWatered = false;
        }

        public void SetFlowerContext(string flowerName)
        {
            FlowerName = flowerName;
            if (!Flower.Flowers.TryGetValue(FlowerName, out Flower flower))
                throw new Exception();

            Flower = flower;

            Color = Flower.Color.ToString().ToLower();
            Flower.FlowerGrown += (stage) => UpdateGrowthStage(stage);
        }

        public void UpdateFlowerSelectionState(SelectionState data)
        {
            State = data;

            switch (State)
            {
                case SelectionState.Default:
                    View.IsButtonEnabled = false;
                    break;
                case SelectionState.Watering:
                    View.IsButtonEnabled = true;
                    break;
                case SelectionState.Deleting:
                    View.IsButtonEnabled = true;
                    break;
                default:
                    View.IsButtonEnabled = false;
                    break;
            }
        }
        private void DeleteTheFlower()
        {
            Flower.Delete();
            Flower = null;

            View.IsButtonEnabled = false;
            View.RefreshAfterDeleting();

            Mediator.RemoveFlowerPresenter(this);
        }
    }
}
