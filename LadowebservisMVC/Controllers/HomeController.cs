using LadowebservisMVC.Controllers.Models;
using LadowebservisMVC.Models;
using LadowebservisMVC.Util;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace LadowebservisMVC.Controllers
{ 

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Ladowebservis";
            return View();
        }




public ActionResult About()
{
    ViewBag.PageTitle = "O nás";
    return View();
}

       // GET: Member

    public ActionResult Member()
    {
        return View();
    }
    public ActionResult Login(MemberModel model)
    {

        if (!ModelState.IsValid)
        {
            if (model.Email == "Email" && model.Password == "Heslo")
            {   

                return RedirectToAction("Member", "Home");
            }
            if (!ModelState.IsValid)
             {
                ModelState.AddModelError("", "Nesprávne meno alebo heslo");
            }
        }
        return View(model);

    }
        public ActionResult Contact()
        {
            ViewBag.PageTitle = "Contact";
            OdoslanieSpravyModel model= new OdoslanieSpravyModel();
            return View(model);
        }
        public ActionResult OdoslanieSpravy(OdoslanieSpravyModel model)
        {
            ViewBag.PageTitle = "Odoslanie správy";
            if (!ModelState.IsValid)
            {
                return View("Contact", model);
            }

            Mailer mailer = new Mailer();
           mailer.OdoslanieEmailu(model);


            return View();
        }

        public ActionResult Registracia()
        {
            ViewBag.PageTitle = "Registracia";
            RegisterModel model = new RegisterModel();  
            return View(model);
        }
        public ActionResult OdoslanieReg(RegisterModel model,OdoslanieRegModel model1)
        {
            ViewBag.PageTitle = "OdoslanieReg";
            if (!ModelState.IsValid)
            {
                return View("Registracia", model);
            }
            Mailer mailer = new Mailer();
            mailer.OdoslanieEmailu(model1);

            return View();
            
        }
        
        //public ActionResult Galeria()
        //{
        //    ViewBag.PageTitle = "Galeria";
        //    return View();
        //}
        //public ActionResult Video()
        //{
        //    ViewBag.PageTitle = "Video";
        //    return View();
        //}
        public ActionResult Hudba()
        {
            ViewBag.PageTitle = "Hudba";
            return View();
        }
        // GET: Memberinfo
        public ActionResult Memberinfo()
        {
            ViewBag.PageTitle = "Memberinfo";
            MemberinfoModel model = new MemberinfoModel();
            return View(model);
        }
        
        




    }


}















