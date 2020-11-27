using HailMary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HailMary1.Controllers
{
    public class CarController : Controller
    {
        readonly CarsDbConnection db = new CarsDbConnection();
        // GET: Car
        public ActionResult Index()
        {
            var cars = db.Cars.ToList();
            return View(cars);
        }
        public ActionResult Delete(int id)
        {
            var cars = db.Cars.Find(id);
            return View(cars);
        }
    }
}