using LadowebservisMVC.Controllers;
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
    public ActionResult Login(LoginModel model)
    {

        if (!ModelState.IsValid)
        {
                if (model.Email == "Name" && model.Heslo == "Heslo")
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
        public ActionResult Kontakt()
        {
            ViewBag.PageTitle = "Kontakt";
            ContactModel model = new ContactModel();


            return View(model);
        }
        public ActionResult OdoslanieSpravy(ContactModel model)
        {
            ViewBag.PageTitle = "Odoslanie správy";
            if (!ModelState.IsValid)
            {
                return View("Odoslanie správy", model);
            }

            Mailer mailer = new Mailer();
            mailer.OdoslanieSpravy(model);


            return View();
        }

        public ActionResult Registracia()
        {
            ViewBag.PageTitle = "Registracia";
            RegisterModel model = new RegisterModel();  
            return View(model);
        }
        public ActionResult OdoslanieReg(RegisterModel model)
        {
            ViewBag.PageTitle = "OdoslanieReg";
            if (!ModelState.IsValid)
            {
                return View("Registracia", model);
            }
            Mailer mailer = new Mailer();
            mailer.OdoslanieEmailu(model);

            return View();
            
        }
       public ActionResult ZberUdajov(ZberUdajovModel model)
        {
            ViewBag.PageTitle = "Zber údajov";

            ZberUdajovModel Model = new ZberUdajovModel();
            if (ModelState.IsValid)
            {
                int cislo = int.Parse(model.Vstup2);
                if (cislo < 10)
                {
                    ModelState.AddModelError("", "Zadajte čislo 10 a viac");
                }
            }

            if (!ModelState.IsValid) //toto sa rovna zapisu (ModelState.IsValid == false),alebo skr. zapis(ModelState.IsValid)je rovny== true
            {
                return View("ZberUdajov", model);
            }
            model.Url = Request.Url.ToString();
            model.Params = Request.Params.ToString();
            model.ParamList = Request.Params;

            //Model.Id = Request.Params["id"];
            //Model.Vstup1 = Request.Params["vstup1"];
            //Model.Vstup2 = Request.Params["vstup2"];

            //Model.Id = id;
            //Model.Vstup1 = vstup1;
            //Model.Vstup2 = vstup2;
            //int a = 1;
            //int b = 2;
            //int vysledok = DajSucet(a, b);


            return View(model);
        }
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

            return View();
        }






    }


}















