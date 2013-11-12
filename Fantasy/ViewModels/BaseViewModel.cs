namespace Fantasy.ViewModels
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            CurrentTab = "Home";
        }

        public BaseViewModel(string currentTab)
        {
            CurrentTab = currentTab;
        }

        public string PageTitle { get; set; }

        public string CurrentTab { get; set; }

        public string DisplayMessage { get; set; }

        /// <summary>
        /// Returns a CSS class for whether the given tab name equals the current tab.
        /// </summary>
        /// <param name="tabName">name of the tab to check</param>
        /// <returns>active if the tab is the current tab, empty string if not.</returns>
        public string TabClass(string tabName)
        {
            return (CurrentTab == tabName
                ? "active"
                : "");
        }
    }
}