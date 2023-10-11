namespace postMortem.Web.Data
{
    /// <summary>
    /// Defines a service that can be used to request refresh from a child componet to a parent component.
    /// Based on: https://stackoverflow.com/questions/55775060/blazor-component-refresh-parent-when-model-is-updated-from-child-component
    /// </summary>
    public interface IRefreshService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}
