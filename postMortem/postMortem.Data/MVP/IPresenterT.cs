using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.UI
{
    /// <summary>
    /// The presenter in the MVP pattern is responsible for handling the application's business 
    /// logic and acting as a mediator between the view and the model. It retrieves data from the model, 
    /// formats it for display, and updates the view as needed. It also handles user interactions and updates 
    /// the model accordingly.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    public interface IPresenterT<TView> : IPresenter
        where TView : class, IView
    {
        TView View { get; }
        void SetupView(TView view);
    }
}
