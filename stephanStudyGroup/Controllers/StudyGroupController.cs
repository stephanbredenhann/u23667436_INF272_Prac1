using stephanStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stephanStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        public ActionResult Index()
        {
            List<studyGroupMembers> members = new List<studyGroupMembers>
            {
                
                new studyGroupMembers { StudentNumber = "u23667436", Name = "Stephan", Surname = "Bredenhann", Email = "u23667436@tuks.co.za" },
                new studyGroupMembers { StudentNumber = "u22892549", Name = "Stephan", Surname = "De Vlliers", Email = "u22892549@tuks.co.za" },
                new studyGroupMembers { StudentNumber = "u20782563", Name = "Marnus", Surname = "Vosser", Email = "u20782563@tuks.co.za" },
                new studyGroupMembers { StudentNumber = "u21582698", Name = "Kenny", Surname = "Strydom", Email = "u21582698@tuks.co.za" },
                new studyGroupMembers { StudentNumber = "u21335982", Name = "Albert", Surname = "Venter", Email = "u21335982@tuks.co.za" }
            };

            return View(members);
            
        }
    }
}
