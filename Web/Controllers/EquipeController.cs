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
    public class EquipeController : Controller
    {

        private readonly IContratService ICS;
        private readonly IEquipeService IES;
        private readonly ITropheService ITS;

        public EquipeController(IContratService iCS, IEquipeService iES, ITropheService iTS)
        {
            this.ICS = iCS;
            this.IES = iES;
            this.ITS = iTS;
        }



        // GET: EquipeController
        public ActionResult Index(string filter)
        {
            if (!string.IsNullOrEmpty(filter))
                return View(IES.GetMany(p => p.NomEquipe.Contains(filter)));
            return View(IES.GetMany()); 
        }

        // GET: EquipeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EquipeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Equipe equipe, IFormFile file )
        {
            //ajout image dans bdd
            equipe.Logo = file.FileName;
            IES.Add(equipe);
            IES.Commit();
            //ajout image dans le dossier 
            if (file != null )
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", file.FileName);
                using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream); 
                }
            }

            return RedirectToAction("Index"); 
        }

        // GET: EquipeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquipeController/Edit/5
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

        // GET: EquipeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquipeController/Delete/5
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
