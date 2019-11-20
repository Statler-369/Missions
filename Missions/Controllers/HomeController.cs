using Missions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Missions.Controllers
{
    public class HomeController : Controller
    {
        /*Hard code the missions*/
        public static List<Mission> listMissions = new List<Mission>
        {
            new Mission
            {
                missionName = "California San Bernardino",
                missionPresident = "",
                missionAddress = "7000 Central Avenue Highland, CA 92346",
                missionClimate = "Hot and dry",
                missionLanguage = "English and Spanish",
                missionSymbol = "California symbol",
                dominantReligion = "What's religion?"
            },
            new Mission
            {
                missionName = "Puerto Rico San Juan",
                missionPresident = "President Smart",
                missionAddress = "Urb. Jardines de Caparra, #500 Calle Marginal Norte, Bayamon PR 00959",
                missionClimate = "Hot and Humid",
                missionLanguage = "Spanish",
                missionSymbol = "Puerto Rico Symbol",
                dominantReligion = "Catholic"
            },
            new Mission
            {
                missionName = "Enter another mission",
                missionPresident = "",
                missionAddress = "",
                missionClimate = "",
                missionLanguage = "",
                missionSymbol = "",
                dominantReligion = ""
            }
        };


        public ActionResult Index()
        {
            return View();
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

        public ActionResult Missions()
        {

            ViewBag.MissionNames = listMissions;

            return View();
        }
    }
}