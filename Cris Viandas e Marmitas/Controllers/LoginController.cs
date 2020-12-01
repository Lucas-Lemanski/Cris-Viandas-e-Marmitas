using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Cris_Viandas_e_Marmitas.Controllers
{
    public class LoginController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View(new Customer());
        //}

        //[HttpPost]
        //public IActionResult Index(Customer customer)
        //{
        //    DAL.AppContext appContext = new DAL.AppContext();
        //    //Customer customerDatabase = appContext.Customers.Where(x => x.Email == customer.Email).SingleOrDefault();
        //    if (customerDatabase == null)
        //    {
        //        ViewBag.Error = "Usuário ou senha incorretos!";
        //        return View(customer);
        //    }
        //    else
        //    {
        //        string hash = customer.Hash + customerDatabase.Salt;
        //        //hash = Util.Cryptography.CreateMD5(hash);
        //        if (customerDatabase.Hash == hash)
        //        {
        //            HttpContext.Session.SetString("user", customerDatabase.Name);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            return View(customer);
        //        }
        //    }

        //}
    }
}
