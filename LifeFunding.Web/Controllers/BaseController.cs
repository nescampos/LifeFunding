using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeFunding.Web.Controllers
{
    public class BaseController : Controller
    {

        protected Models.Database.lifefundingEntities db = new Models.Database.lifefundingEntities();
    }
}