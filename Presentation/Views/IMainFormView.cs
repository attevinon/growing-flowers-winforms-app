using System;
using System.Collections.Generic;

namespace Presentation.Views
{
    public interface IMainFormView : IFormView
    {
        List<IFlowerView> FlowersList { get; }
        bool IsSelectionMode { get; set; }
        Action CancelSelection { get; set; }
        Action PlantAFlower { get; set; }
        Action WaterFlowers { get; set; }
        Action DeleteFlowers { get; set; }
        void GetHelp();
    }


}
