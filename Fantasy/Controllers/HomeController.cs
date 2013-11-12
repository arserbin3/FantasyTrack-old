namespace Fantasy.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Models;
    using ViewModels;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                Players = new FantasyContext().Players.ToList()
            };

            return View(viewModel);
        }
    }
}