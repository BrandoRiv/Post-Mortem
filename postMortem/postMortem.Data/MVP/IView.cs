using BlazorBootstrap;
using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace postMortem.Data.UI
{
    /// <summary>
    /// The view in the MVP pattern is responsible for displaying the data to the user and handling user 
    /// interactions.It is a passive component, meaning that it does not contain any logic for fetching 
    /// or manipulating data. Instead, the view delegates all of its logic to the presenter.
    /// </summary>
    public interface IView
    {
        void ShowErrorMessage(Exception e);
        void UpdateView();

        Task Load();
    }
}
