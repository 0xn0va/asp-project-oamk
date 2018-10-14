using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_project_oamk.Models;

namespace asp_project_oamk.Controllers
{
    public class ProducerController : Controller
    {
        [HttpPost]
        public ActionResult AddNewProducer (String name , String sex, String dob , String bio)
        {
            Producer producer = new Producer();
            producer.Name = name;
            producer.Sex = sex;
            producer.DOB = Convert.ToDateTime(dob);
            producer.Bio = bio;

            try
            {
                using (IMDBContext db = new IMDBContext())
                {
                    db.Producers.Add(producer);
                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
            return Json(new { Success = true });
        }
    }
}