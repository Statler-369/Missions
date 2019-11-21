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
                missionPresident = "President Dixon",
                missionAddress = "7000 Central Avenue Highland, CA 92346",
                missionClimate = "Hot and dry",
                missionLanguage = "English and Spanish",
                missionSymbol = "CaliSymbol.jpg",
                dominantReligion = "What's religion?"
            },
            new Mission
            {
                missionName = "Puerto Rico San Juan",
                missionPresident = "President Smart",
                missionAddress = "Urb. Jardines de Caparra, #500 Calle Marginal Norte, Bayamon PR 00959",
                missionClimate = "Hot and Humid",
                missionLanguage = "Spanish",
                missionSymbol = "PuertoRicoSymbol.jpg",
                dominantReligion = "Catholic"
            },
            new Mission
            {
                missionName = "Indonesia Jakarta Mission",
                missionPresident = "President Rowley",
                missionAddress = "Jalan Senopati 115 Kebayoran Baru Jakarta, 12190, Indonesia",
                missionClimate = "Hot and Humid",
                missionLanguage = "Indonesian",
                missionSymbol = "IndonesiaSymbol.jfif",
                dominantReligion = "Islam"
            }
        };

        public static List<MissionQuestions> listMissionQuestions = new List<MissionQuestions>
        {
            new MissionQuestions
            {
                missionDetails = listMissions[0],
                questions = new List<string>(),
                answers = new List<string>()
            },

            new MissionQuestions
            {
                missionDetails = listMissions[1],
                questions = new List<string>(),
                answers = new List<string>()
            },

            new MissionQuestions
            {
                missionDetails = listMissions[2],
                questions = new List<string>(),
                answers = new List<string>()
            }
        };

        /**********************************************************************************
            Hard code the questions and answers in the object
        **********************************************************************************/

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
            ViewBag.Dictionary = new Dictionary<string, string>
            {
                {"What was your favorite food?", "I hated all the food, I was sick the entire time :("},
                {"What was the weather like?", "Very hot. I wish I had brought more short-sleeve shirts and less sweaters."},
                {"What is the church like here?", "The members are incredible! Lots of work to be done, the field is white ALREADY to harvest!!!"}
            };
            return View("MissionInfo", listMissions.Find(x => x.missionName == missionName));
        }
    }
}