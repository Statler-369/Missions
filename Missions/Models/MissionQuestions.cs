﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Missions.Models
{
    public class MissionQuestions
    {
        public Mission missionDetails { get; set; }
        public List<string> questions { get; set; }
        public List<string> answers { get; set; }

        public MissionQuestions()
        {

        }
    }
}