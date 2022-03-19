
using System;

namespace Presentation.Views
{
    public interface IFlowerView : IView
    {
        string FlowerName { get; set; }
        bool IsWatered { get;  set; }
        bool IsButtonEnabled { get; set; }
        int Id { get; }
        string ImageName { set; }
        Action ActWithFlower { get; set; }
        void RefreshAfterDeleting();
    }
}
