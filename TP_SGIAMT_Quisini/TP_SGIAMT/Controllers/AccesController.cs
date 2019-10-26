using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;
using System.Security.Cryptography;



namespace TP_SGIAMT.Controllers
{
    public class AccesController : Controller
    {
    
        private readonly DB_A4D4D9_BDSGIAMTContext _context;
        public object Session { get;  set; }

        public IActionResult LogIn()
        {
            return View();
        }

        public AccesController(DB_A4D4D9_BDSGIAMTContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TUsuario.Include(t => t.FkItuTipoUsuarioNavigation).Include(t => t.FkIuCodCategoriaNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }

        
        //public ActionResult LogIn(string txtUsuario)
        //{

        //    TUsuario tuser = new TUsuario();

        //    if (txtUsuario == tuser.PkIuDni.ToString())
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Acces", "LogIn");
        //    }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(TUsuario user)
        {
            if (ModelState.IsValid)
            {
                //using (DB_A4D4D9_BDSGIAMTContext db = new DB_A4D4D9_BDSGIAMTContext())
                
                    var obj = _context.TUsuario.Where(u => u.PkIuDni.Equals(user.PkIuDni) && u.VuContraseña.Equals(user.VuContraseña)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["PK_IU_Dni"] = obj.PkIuDni.ToString();
                        Session["VuContraseña"] = obj.VuContraseña.ToString();
                        return RedirectToAction("Index");
                    }
                

            }
            return View(user);


        }


        //try
        //{
        //    using ()
        //    {
        //        var oUser = (from d in db.usuario
        //                     where d.email == Usuario.Trim() && d.password == Password.Trim()
        //                     select d).FirstOrDefault();
        //        if (oUser == null)
        //        {
        //            ViewBag.Error = "Usuario o contraseña invalida";
        //            return View();
        //        }

        //        Session["User"] = oUser;

        //    }

        //    return RedirectToAction("Index", "Home");
        //}
        //catch (Exception ex)
        //{
        //    ViewBag.Error = ex.Message;
        //    return View();
        //}


    }
}
