using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using HwProj.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HwProj.Controllers
{
    public class CarController : Controller
    {
        private readonly IRepository _repository;

        public CarController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: Car
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: Car/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_repository.Get(id));
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                _repository.Create(car);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_repository.Get(id));
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Car car)
        {
            try
            {
                _repository.Edit(car);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_repository.Get(id));
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Car carView)
        {
            try
            {
                _repository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
