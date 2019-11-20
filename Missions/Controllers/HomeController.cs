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
                missionName = "Enter another mission",
                missionPresident = "",
                missionAddress = "",
                missionClimate = "",
                missionLanguage = "",
                missionSymbol = "",
                dominantReligion = ""
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

        [HttpPost]
        public ActionResult Missions(string missionName)
        {
            MissionQuestions mission = new MissionQuestions
            {
                missionDetails = listMissions.Find(x => x.missionName == missionName)
            };

            return View("MissionInfo", mission);
        }
    }
}