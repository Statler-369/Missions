using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Missions.Models
{
    public class Mission
    {
        [Display(Name ="Mission Name")]
        public string missionName {get; set;}

        [Display(Name = "Mission President")]
        public string missionPresident {get; set;}

        [Display(Name = "Mission Address")]
        public string missionAddress {get; set;}

        [Display(Name = "Mission Language")]
        public string missionLanguage {get; set;}

        [Display(Name = "Mission Climate")]
        public string missionClimate {get; set;}

        [Display(Name = "Dominate Religion")]
        public string dominantReligion {get; set;}

        [Display(Name = "Mission Symbol")]
        public string missionSymbol {get; set;}

        public Mission()
        {

        }
    }
}