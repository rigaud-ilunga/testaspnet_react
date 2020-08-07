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
        public ActionResult Create(ContactModel contact)
        {
            this._contacts.InsertContact(contact);
            return RedirectToAction("List", _contacts.SelectAll());
        }

        public ActionResult AfficherTousEtudiant()
        {

            return View(
                _contacts.SelectAll());
        }

        public ActionResult Edit(string contactId)
        {
            return View(_etudiants.Get(contactId));
        }

        [HttpPost]
        public ActionResult Edit(string Id, EtudiantModels etudiant)
        {
            this._etudiants.UpdateContact(Id, etudiant);

            return RedirectToAction("List",
                 _etudiants.SelectAll());
        }

    }
}