namespace Fantasy.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using ViewModels;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                Players = FantasyModel.Players.ToList(),
                Teams = FantasyModel.Teams.ToList()
            };

            return View(viewModel);
        }
    }
}