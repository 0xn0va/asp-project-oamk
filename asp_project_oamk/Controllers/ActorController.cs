using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_project_oamk.Models;

namespace asp_project_oamk.Controllers
{
    public class ActorController : Controller
    {

        [HttpPost]
        public ActionResult AddNewActor(String name, String sex, String dob,String bio)
        {

            Actor actor = new Actor();
            actor.Name = name;
            actor.Sex = sex;
            actor.DOB = Convert.ToDateTime(dob);
            actor.Bio = bio;

            try
            {
                using (IMDBContext db = new IMDBContext())
                {
                    db.Actors.Add(actor);
                    db.SaveChanges();
                }

            }
            catch(Exception e)
            {

            }
            return Json(new { Success = true });
            
        }
    }
}