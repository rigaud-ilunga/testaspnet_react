using System;
using System.Web;
using test_eteyelo.Models;
namespace test_eteyelo.Controllers
{
    public class EtudiantController
    {
        private EtudiantModels _etudiants = new EtudiantModels();
        //
        // GET: /ContactUs/

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Etudiant etudiant)
        {
            this._etudiants.Create(etudiant);
            return RedirectToAction("List", _etudiants.getAllEtudiant());
        }

        public ActionResult AfficherTousEtudiant()
        {
            return View( _etudiants.getAllEtudiant());
        }

        public ActionResult Edit(string Id)
        {
            return View(_etudiants.Get(Id));
        }

        [HttpPost]
        public ActionResult Edit(string Id, EtudiantModels etudiant)
        {
            this._etudiants.Update(Id, etudiant);

            return RedirectToAction("List",_etudiants.getAllEtudiant());
        }

    }
}