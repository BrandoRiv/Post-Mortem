using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.UI
{
    /// <summary>
    /// The view in the MVP pattern is responsible for displaying the data to the user and handling user 
    /// interactions.It is a passive component, meaning that it does not contain any logic for fetching 
    /// or manipulating data. Instead, the view delegates all of its logic to the presenter.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IViewT<TModel> : IView
        where TModel : class
    {
        TModel Model { get; set; }
    }
}
