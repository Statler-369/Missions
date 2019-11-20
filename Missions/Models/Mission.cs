using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Missions.Models
{
    public class Mission
    {
        public string missionName {get; set;}
        public string missionPresident {get; set;}
        public string missionAddress {get; set;}
        public string missionLanguage {get; set;}
        public string missionClimate {get; set;}
        public string dominantReligion {get; set;}
        public string missionSymbol {get; set;}

        public Mission()
        {

        }
    }
}