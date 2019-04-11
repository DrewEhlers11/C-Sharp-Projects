using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.Where(x => x.CarModel == null).ToList();   //Lambda expression of getting specified data
                /*var signups = (from c in db.SignUps where c.Removed == null select c).ToList();  *///Linq Method of getting specified data
                var insurers = new List<Insuree>();
                foreach (var insuree in insurees)
                {
                    var insurer = new Insuree();
                    insuree.Id = insurer.Id;
                    insuree.FirstName = insurer.FirstName;
                    insuree.LastName = insurer.LastName;
                    insuree.EmailAddress = insurer.EmailAddress;
                    //insuree.Add(insurees);
                }
                return View(insurees);
            }
        }

    }
}
