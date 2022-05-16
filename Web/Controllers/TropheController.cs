using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GP.Domain.Entities;
using GP.Data;
using GP.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace GP.Web.Controllers
{
    public class TropheController : Controller
    {
        private readonly IContratService ICS;
        private readonly IEquipeService IES;
        private readonly ITropheService ITS;

        public TropheController(IContratService iCS, IEquipeService iES, ITropheService iTS)
        {
            this.ICS = iCS;
            this.IES = iES;
            this.ITS = iTS;
        }
        // GET: TropheController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TropheController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TropheController/Create
        public ActionResult Create()
        {
            ViewBag.EquipeIdFK = new SelectList(IES.GetMany(), "EquipeId", "NomEquipe");
            return View();
        }

        // POST: TropheController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TropheController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TropheController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TropheController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TropheController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
