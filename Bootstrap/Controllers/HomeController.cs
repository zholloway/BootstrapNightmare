using Bootstrap.DataContext;
using Bootstrap.Models;
using Bootstrap.Services;
using Bootstrap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public static TIYSportsContext database = new TIYSportsContext();

        public static SportServices sportsServices = new SportServices(database);
        static List<Sport> sports = sportsServices.GetAllSports();

        public static TeamServices teamsServices = new TeamServices(database);
        static List<Team> teams = teamsServices.GetAllTeams();

        public static GameServices gameServices = new GameServices(database);
        static List<Game> games = gameServices.GetAllGames();

        IndexVM model = new IndexVM(teams, sports, games);

        public ActionResult Index()
        {
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}