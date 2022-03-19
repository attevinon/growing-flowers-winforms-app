using Presentation.Common;
using Presentation.Common.PresenterAbstractions;
using Presentation.Views;
using Models;
using System;

namespace Presentation.Presenters
{
    public class PlantAFlowerPresenter : BaseFormPresenter<IPlantAFlowerFormView>
    {
        public PlantAFlowerPresenter(ApplicationController controller, IPlantAFlowerFormView view)
            : base(controller, view)
        {
            //binding combobox with enum
            //to-do: localization
            View.Colors = Enum.GetValues(typeof(FlowerColor));

            View.PlantAFlower += () => PlantAFLower(View.FlowerName, View.SelectedColor);
        }

        private void PlantAFLower(string name, int colorConst)
        {
            if (!Enum.IsDefined(typeof(FlowerColor), colorConst))
            {
                throw new Exception();
            }

            if (string.IsNullOrEmpty(name))
            {
                View.ShowErrorMessage(ERROR_MESSAGE.NAME_IS_EMPTHY);
                return;
            }

            if (name.Length >= 20)
            {
                View.ShowErrorMessage(ERROR_MESSAGE.NAME_IS_TOO_LONG);
                return;
            }

            if (Flower.Flowers.ContainsKey(name))
            { 
                View.ShowErrorMessage(string.Format(ERROR_MESSAGE.NAME_IS_ALREADY_EXISTS, name));
                return;
            } 

            new Flower(name, colorConst);

            View.Close();

            Controller.RegisterFlowerPresenter<FlowerPresenter>(name);
        }

        public override void Run()
        {
            View.Show();
        }
    }
}