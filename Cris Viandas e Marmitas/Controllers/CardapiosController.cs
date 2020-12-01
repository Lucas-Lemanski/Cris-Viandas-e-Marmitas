using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cris_Viandas_e_Marmitas.Controllers
{
    public class CardapiosController : Controller
    {
        //public IActionResult Index(int? cardapiosId)
        //{
        //    DAL.AppContext contexto = new DAL.AppContext();
        //    IEnumerable<Cardapios> lsCardapios = contexto.Cardapios;
        //    if (cardapiosId.HasValue)
        //    {
        //        lsCardapios = lsCardapios.Where(x => x.Id == cardapiosId.Value);
        //    }
        //    lsCardapios = lsCardapios.OrderBy(x => x.Id).ToList();
        //    ViewBag.Cardapios = contexto.Cardapios.OrderBy(x => x.Id).ToList();
        //    return View(lsCardapios);
        //}

        public IActionResult Index()
        {
            DAL.AppContext context = new DAL.AppContext();
            Cardapios prato = context.Cardapios.Find();
            return View(prato);
        }
    }
}
