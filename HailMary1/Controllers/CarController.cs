using HailMary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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
        public ActionResult Edit(int id)
        {
            var car = db.Cars.Find(id);
            return View(car);
        }
        [HttpPost]
        public ActionResult Edit(int id, Car c)
        {
            var car = db.Cars.Find(id);
            try
            {
                car.Nombre = c.Nombre;
                car.Descripcion = c.Descripcion;
                car.Precio = c.Precio;
                //db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(car);
            }
        }
        public ActionResult Details(int id)
        {
            var cars = db.Cars.Find(id);
            return View(cars);
        }
        public ActionResult Delete(int id)
        {
            var cars = db.Cars.Find(id);
            return View(cars);
        }
        [HttpPost]
        public ActionResult Delete(int id, Car c)
        {
            var car = db.Cars.Find(id);
            try
            {
                db.Cars.Remove(car);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(car);
            }
        }
    }
}