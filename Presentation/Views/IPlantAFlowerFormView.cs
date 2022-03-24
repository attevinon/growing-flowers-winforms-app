using System;


namespace Presentation.Views
{
    public interface IPlantAFlowerFormView : IFormView
    {
        string FlowerName { get; set; }
        int SelectedColor { get; set; }
        Array Colors { get; set; }
        Action PlantAFlower { get; set; }
        void ShowErrorMessage(string message);
    }
}
