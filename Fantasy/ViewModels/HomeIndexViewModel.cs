namespace Fantasy.ViewModels
{
    using System.Collections.Generic;
    using Models;

    public class HomeIndexViewModel : BaseViewModel
    {
        public HomeIndexViewModel()
        {
        }

        public List<Player> Players { get; set; }
    }
}