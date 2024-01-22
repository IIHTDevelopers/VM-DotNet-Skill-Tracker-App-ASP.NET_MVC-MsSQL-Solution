using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTrackerApp.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string SkillName { get; set; }
        public bool IsCompleted { get; set; }
        public string Notes { get; set; }
    }

}