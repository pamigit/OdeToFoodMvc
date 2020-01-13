using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class HotelsController : Controller
    {
        IRestaurantData db;
        public HotelsController(IRestaurantData db)
        {
            this.db = db;
        }
        // GET: Hotels
        public ActionResult Index()
        {
            var model = db.GetAllHotels();
            return View(model);
        }
    }
}