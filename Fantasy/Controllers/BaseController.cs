namespace Fantasy.Controllers
{
    using System.Web.Mvc;
    using Helpers;
    using Models;
    using StackExchange.Profiling;

    public class BaseController : Controller
    {
        private FantasyContext _model;

        ////private MillenniumDataContext _mill;
        ////private IntranetDataContext _intranet;
        private MiniProfiler _profiler;

        public FantasyContext FantasyModel
        {
            get
            {
                return _model ?? (_model = MiniProfilerHelper.Create<FantasyContext>());
            }
        }

        ////public IntranetDataContext IntranetModel
        ////{
        ////    get
        ////    {
        ////        return _intranet ?? (_intranet = MiniProfilerHelper.Create<IntranetDataContext>());
        ////    }
        ////}

        ////public MillenniumDataContext MillenniumModel
        ////{
        ////    get
        ////    {
        ////        return _mill ?? (_mill = MiniProfilerHelper.Create<MillenniumDataContext>());
        ////    }
        ////}

        protected MiniProfiler Profiler
        {
            get
            {
                return _profiler ?? (_profiler = MiniProfiler.Current);
            }
        }

        /// <summary>
        /// Gets a value indicating whether debug mode is enabled
        /// </summary>
        public bool IsDebuggingEnabled
        {
            // TODO: consider cacheing this like the other properties
            get
            {
                return ControllerContext.HttpContext.IsDebuggingEnabled;
            }
        }

        /// <summary>
        /// Displays a not authorized message.
        /// </summary>
        ////public ViewResult NotAuthorized(string message, string currentTab = null, Form form = null)
        ////{
        ////    var viewModel = new BaseViewModel
        ////    {
        ////        DisplayMessage = message ?? Constants.NotAuthorized.General,
        ////        PageTitle = "Not Authorized",
        ////        CurrentTab = currentTab,
        ////        Form = form
        ////    };

        ////    return View("NotAuthorized", viewModel);
        ////}
    }
}