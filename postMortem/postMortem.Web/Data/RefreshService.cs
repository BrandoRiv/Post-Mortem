
namespace postMortem.Web.Data
{
    /// <summary>
    /// Defines a service that can be used to request refresh from a child componet to a parent component.
    /// Based on: https://stackoverflow.com/questions/55775060/blazor-component-refresh-parent-when-model-is-updated-from-child-component
    /// </summary>
    public class RefreshService : IRefreshService
    {
        /// <summary>
        /// Subscribe to this event to know when a page should be refreshed from a parent.
        /// </summary>
        public event Action RefreshRequested;

        /// <summary>
        /// Call <see cref="RefreshRequested"/> event.
        /// </summary>
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
