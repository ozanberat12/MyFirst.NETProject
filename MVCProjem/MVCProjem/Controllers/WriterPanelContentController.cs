using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjem.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        WriterLoginManager wlm = new WriterLoginManager(new EfWriterDal());
        Context c = new Context();
        public ActionResult MyContent(string mail)
        {
            ///*int id = 1;*///bunun yarine session dan gelen id lazım
            //mail = (string)Session["WriterMail"];
            //var writeridinfo = wlm.GetWriterMail(mail);
            //var values = cm.GetListByWriter(writeridinfo); //bir id değeri yollanması lazım
            //return View(values);


            mail = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
            var contentvalues = cm.GetListByWriter(writeridinfo);
            return View(contentvalues);
            //bu kısmı daha sonra düzelt
        }
        public ActionResult ContentByHeadingID(int id)
        {
            var valueheading = cm.GetListByHeadingID(id);
            return View(valueheading);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddContent(Content p)
        {
            string mail = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();

            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = writeridinfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);
            return RedirectToAction("MyContent");
        }
        [HttpGet]
        public ActionResult EditContent(int id)
        {
            var contentvalue = cm.GetByID(id);
            return View(contentvalue);
        }
        [HttpPost]
        public ActionResult EditContent(Content p)
        {
            cm.ContentUpdate(p);
            return RedirectToAction("MyContent");
        }
        public ActionResult DeleteContent(int id)
        {
            var value = cm.GetByID(id);
            value.ContentStatus = false;
            cm.ContentDelete(value);
            return RedirectToAction("MyContent");
        }
    }
}