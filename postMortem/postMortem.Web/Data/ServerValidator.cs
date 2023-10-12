namespace postMortem.Web.Data
{
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components;

    /// <summary>
    /// Helps with creating custom error messages. Help gathered from:
    /// </summary>
    /// <see cref="https://remibou.github.io/Using-the-Blazor-form-validation/"/>
    /// <see cref="https://stackoverflow.com/questions/69724492/blazor-editform-custom-validation-message-on-form-submission"/>
    /// <see cref="https://learn.microsoft.com/en-us/aspnet/core/blazor/forms-and-input-components?view=aspnetcore-6.0#basic-validation"/>
    public class ServerSideValidator : ComponentBase
    {
        /// <summary>
        /// Gets or sets the message store.
        /// </summary>
        public ValidationMessageStore MessageStore
        {
            get { return messageStore; }
            protected set { messageStore = value; }
        }
        private ValidationMessageStore? messageStore;

        [CascadingParameter]
        protected EditContext? CurrentEditContext { get; set; }

        /// <summary>
        /// Initialize the component.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        protected override void OnInitialized()
        {
            if (CurrentEditContext is null)
            {
                throw new InvalidOperationException(
                    $"{nameof(ServerSideValidator)} requires a cascading " +
                    $"parameter of type {nameof(EditContext)}. " +
                    $"For example, you can use {nameof(ServerSideValidator)} " +
                    $"inside an {nameof(EditForm)}.");
            }

            messageStore = new(CurrentEditContext);

            CurrentEditContext.OnValidationRequested += OnValidationRequestedAsync;
            CurrentEditContext.OnFieldChanged += (s, e) => messageStore?.Clear(e.FieldIdentifier);
        }

        /// <summary>
        /// This method is called when submit is pressed. Do custom validation in this method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual async void OnValidationRequestedAsync(object sender, ValidationRequestedEventArgs e)
        {
            // clear previous error messages
            messageStore.Clear();
        }

        /// <summary>
        /// Add an error message to context.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="message"></param>
        public void DisplayError(string fieldName, string message)
        {
            messageStore?.Add(CurrentEditContext.Field(fieldName), message);
            CurrentEditContext.NotifyValidationStateChanged();
        }

        /// <summary>
        /// Adds a dictionary of error messages to the context.
        /// </summary>
        /// <param name="errors"></param>
        public void DisplayError(Dictionary<string, List<string>> errors)
        {
            foreach (KeyValuePair<string, List<string>> error in errors)
            {
                messageStore?.Add(CurrentEditContext.Field(error.Key), error.Value);
            }

            CurrentEditContext.NotifyValidationStateChanged();
        }

        /// <summary>
        /// Clear the current list of errors.
        /// </summary>
        public void ClearErrors()
        {
            messageStore?.Clear();
            CurrentEditContext?.NotifyValidationStateChanged();
        }
    }
}
