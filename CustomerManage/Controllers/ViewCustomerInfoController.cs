using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerManage.Models;

namespace CustomerManage.Controllers
{
    public class ViewCustomerInfoController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: ViewCustomInfoes
        public ActionResult Index()
        {
            return View(db.ViewCustomInfoes.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
