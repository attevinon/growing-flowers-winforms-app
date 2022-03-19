﻿

namespace Presentation.Views
{
    public interface IFormView : IView
    {
        void Show();
        void Close();
        void ShowErrorMessage(string message);
    }
}
