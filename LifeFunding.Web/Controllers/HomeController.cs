using LifeFunding.Web.Models;
using LifeFunding.Web.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeFunding.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ListCauses()
        {
            var causes = db.Causes.OrderBy(x => x.Deadline);
            return View(causes);
        }

        public ActionResult ViewCause(int id) //acá se debería donar
        {
            Cause cause = db.Causes.SingleOrDefault(x => x.Id == id);
            return View(cause);
        }

        public ActionResult CreateCause()
        {
            CreateCauseViewModel model = new CreateCauseViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateCause(CreateCauseFormModel Form)
        {
            if(!ModelState.IsValid)
            {
                CreateCauseViewModel model = new CreateCauseViewModel();
                model.Form = Form;
                return View(model);
            }
            Cause cause = new Cause
            {
                  AmountAchieved = 0, Website = Form.Website, StellarAddress = Form.StellarAddress,
                  FundGoal = Form.FundGoal, CreatedAt = DateTime.Now, Name = Form.Name, Description = Form.Description,
                  Deadline = Form.Deadline, Photo = Form.UrlPhoto
            };
            db.Causes.Add(cause);
            db.SaveChanges();
            return RedirectToAction("ViewCause", new { id = cause.Id });
        }

        public ActionResult CauseCreated(int id)
        {
            return View();
        }

        public ActionResult CreateStellarAddress()
        {
            return View();
        }

    }
}