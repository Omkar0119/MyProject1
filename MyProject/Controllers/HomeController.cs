using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        cloneTempleteEntities1 db=new cloneTempleteEntities1();
        // GET: Home
        public ActionResult Index()
        {
            var x=db.CloneTamplate1.ToList();
            return View(x);
        }
        public ActionResult create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult create(CloneTamplate1 c)
        {
            if (c.isworking == true)
            {
                db.InsertCloneTemplate(c.tamplateName, c.createdon, c.createdby, c.isworking);
                db.SaveChanges();
                return View();
            }
            return View();
        }
        public ActionResult update(int id)
        {
            var x= db.CloneTamplate1.Where(a=>a.cloneId==id).FirstOrDefault();
            return View(x);
        }
        [HttpPost]
        public ActionResult update(CloneTamplate1 c)
        {

            //db.UpdateCloneTemplate(c.tamplateName, c.createdon, c.createdby, c.isworking);
            db.UpdateCloneTemplate(c.cloneId, c.Tamplateid, c.tamplateName, c.createdon,c.createdby, c.isworking);
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var x = db.CloneTamplate1.Where(a => a.cloneId == id).FirstOrDefault();
            return View(x);
        }
        [HttpPost]
        public ActionResult Delete(CloneTamplate1 c)
        {
            db.DeleteCloneTemplate(c.cloneId);
               db.SaveChanges();
            return View();
        }

    }

}

