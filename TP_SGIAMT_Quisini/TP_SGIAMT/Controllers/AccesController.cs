﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP_SGIAMT.Models;
using System.Security.Cryptography;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using Nancy.Session;
<<<<<<< HEAD
=======
=======


>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81

namespace TP_SGIAMT.Controllers
{
    public class AccesController : Controller
    {
<<<<<<< HEAD

        private readonly DB_A4D4D9_BDSGIAMTContext _context;
        public AccesController(DB_A4D4D9_BDSGIAMTContext context)
        {

            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }


=======
<<<<<<< HEAD
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly ILogger<TUsuario> _logger;
        private readonly DB_A4D4D9_BDSGIAMTContext _context;
        //public Object session { get;  set; }
        public Session session1 { get; set; }
=======
    
        private readonly DB_A4D4D9_BDSGIAMTContext _context;
        public object Session { get;  set; }
>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439

        public IActionResult LogIn()
        {
            return View();
        }

        public AccesController(DB_A4D4D9_BDSGIAMTContext context)
        {
<<<<<<< HEAD
           
            _context = context;
        }
        //public InputModel Input { get; set; }



        //public class InputModel
        //{
            
        //    [Required(ErrorMessage = "<font color='red'>El campo DNI es obligatorio!</font>")]
        //    //[StringLength(100, ErrorMessage = "<font color='red'>El numero de caracteres de {0} debe ser al " +
        //    //    "menos {2}.</font>", MinimumLength = 8)]
        //    public int PkIuDni { get; set; }

        //    //-------------Pass--------------------
        //    [Required(ErrorMessage = "<font color='red'>Contraseña es obligatorio!</font>")]
        //    [DataType(DataType.Password)]
        //    public string VuContraseña { get; set; }
        //    //---------------------------------
        //}


        //public async Task<IActionResult> Index()
        //{
        //    var dB_A4F05E_SGIAMTPContext = _context.TUsuario.Include(t => t.FkItuTipoUsuarioNavigation).Include(t => t.FkIuCodCategoriaNavigation);
        //    return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        //}
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81

        public ViewResult NotFound(System.Web.Mvc.HandleErrorInfo exception)
        {
            ViewBag.Title = "Page Not Found";
            return View("Error", exception);
        }

<<<<<<< HEAD
        public class usr
        {
            public int dniusr { get; set; }
            public string passusr { get; set; }
            public int? tipousr { get; set; }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(login user)
        {
            //    bool dni = _context.TUsuario.Any(x => x.PkIuDni == user.Dni);
            //    bool contra = _context.TUsuario.Any(con => con.VuContraseña == user.Contra);


            var us = (from c in _context.TUsuario
                      where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                      select new usr()
                      {
                          dniusr = c.PkIuDni,



                      }).FirstOrDefault();
            var us1 = (from c in _context.TUsuario
                       where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                       select new usr()
                       {
                           passusr = c.VuContraseña,


                       }).FirstOrDefault();
            var us2 = (from c in _context.TUsuario
                       where c.PkIuDni == user.Dni && c.VuContraseña == user.Contra
                       select new usr()
                       {
                           tipousr = c.FkItuTipoUsuario


                       }).FirstOrDefault();


            if (us == null && us1 == null && us2 == null)
            {
                ModelState.AddModelError("Errores", "Los datos son incorrectos");

                return RedirectToAction("LogIn", "Acces");

            }

            else
            {
                bool dni = _context.TUsuario.Any(x => x.PkIuDni == us.dniusr);
                bool contra = _context.TUsuario.Any(con => con.VuContraseña == us1.passusr);

                if (dni == true && contra == true && us2.tipousr == 1)
                {
                    await Task.Delay(100);
                    //HttpContext.Session.SetString("user", "user");
                    return RedirectToAction("ParticipanteView", "Participante");
                    //return RedirectToAction("Index", "Home");
                }
                else if (dni == true && contra == true && us2.tipousr == 2) //ariana
                {

                    return RedirectToAction("AdministradorView", "Admin");
                }
                else if (dni == true && contra == true && us2.tipousr == 3) //ariana
                {

                    return RedirectToAction("JuradoView", "Jurado");
                }
                else if (dni == true && contra == true && us2.tipousr == 4) //ariana
                {

                    return RedirectToAction("PresentadorView", "Presentador");
                }
                else
                {
                    return RedirectToAction("LogIn", "Acces");
                }
            }
        }

=======

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TUsuario user)
        {
            {
                var obj = _context.TUsuario.Where(u => u.PkIuDni.Equals(user.PkIuDni) && u.VuContraseña.Equals(user.VuContraseña)).FirstOrDefault();
                if (obj != null)
                {
                    session1["PK_IU_Dni"] = obj.PkIuDni.ToString();
                    session1["VuContraseña"] = obj.VuContraseña.ToString();
                    return RedirectToAction("Index");
                }
                return View(user);
            }
        }
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            //var errors = ModelState.Values.SelectMany(v => v.Errors);
        //            DB_A4D4D9_BDSGIAMTContext db = new DB_A4D4D9_BDSGIAMTContext();
        //            //var getUser = db.TUsuario.Single(p => p.PkIuDni== user.PkIuDni && p.VuContraseña== user.VuContraseña);
        //            TUsuario obj = _context.TUsuario.Where(u => u.PkIuDni.Equals(user.PkIuDni) && u.VuContraseña.Equals(user.VuContraseña)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                session1["PK_IU_Dni"] = user.PkIuDni.ToString();
        //                session1["VU_Contraseña"] = user.VuContraseña.ToString();            
        //                return RedirectToAction("Index", "Home");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Username or Password does not match.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error", new System.Web.Mvc.HandleErrorInfo(ex, "", ""));
        //    }

        //    return View();
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult LogIn(TUsuario user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //using (DB_A4D4D9_BDSGIAMTContext db = new DB_A4D4D9_BDSGIAMTContext())

        //        var obj = _context.TUsuario.Where(u => u.PkIuDni.Equals(user.PkIuDni) && u.VuContraseña.Equals(user.VuContraseña)).FirstOrDefault();
        //        if (obj != null)
        //        {
        //            session1["PK_IU_Dni"] = obj.PkIuDni.ToString();
        //            session1["VuContraseña"] = obj.VuContraseña.ToString();
        //            return RedirectToAction("Index");
        //        }


        //    }
        //    return View(user);


        //}



        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> LogIn(String usr=null)
        //{   
        //    usr = usr ?? Url.Content("~/");
        //    if (ModelState.IsValid)
        //    { }
        //    //var result = await _signInManager.CheckPasswordSignInAsync(Input.PkIuDni, Input.VuContraseña ,  lockoutOnFailure: true);
        //    //    if (result.Succeeded)
        //    //    {
        //    //        _logger.LogInformation("User logged in.");
        //    //        return LocalRedirect(usr);
        //    //    }
        //    //    else
        //    //    {
        //    //        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        //    //        return View();
        //    //    }
        //    //}
        //    return View();
        //}




        //public async Task<IActionResult>LogIn(TUsuario usr)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }


        //    return View(usr);
        //}




        //{
        //    //Member m = new Member();

        //    Session["PK_IU_Dni"] = Convert.ToString(usr.PkIuDni);
        //    Session["VuContraseña"] = usr.VuContraseña.ToString();
        //    usr.VuContraseña = Request.Form["I"];
        //    if (ModelState.IsValid)
        //    {
        //        return View("Index", usr);
        //    }
        //    else
        //    {

        //        return View("LogIn", usr);
        //    }
        //}



        //{
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var errors = ModelState.Values.SelectMany(v => v.Errors);
        //            DB_A4D4D9_BDSGIAMTContext db = new DB_A4D4D9_BDSGIAMTContext();

        //            var getUser = db.TUsuario.Single(p => p.PkIuDni== usr.PkIuDni && p.VuContraseña== usr.VuContraseña);
        //            if (getUser != null)
        //            {
        //                Session= usr.PkIuDni.ToString();
        //                Session= usr.VuContraseña.ToString();
        //                return RedirectToAction("Home", "Index");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "Username or Password does not match.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("Error", new System.Web.Mvc.HandleErrorInfo(ex, "", ""));
        //    }

        //    return View();
        //}

        //return View(usr);    


        //{
        //    var obj = _context.TUsuario.Where(u => u.PkIuDni.Equals(model.PkIuDni) && u.VuContraseña.Equals(model.VuContraseña)).FirstOrDefault();
        //    if (obj != null)
        //    {
        //        //Session["PK_IU_Dni"] = obj.PkIuDni.ToString();
        //        //Session["VuContraseña"] = obj.VuContraseña.ToString();
        //        return RedirectToAction("Index");
        //    }
        //}
        //return View(model);
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
<<<<<<< HEAD

=======
   
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81


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



<<<<<<< HEAD
=======
=======
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
>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439
>>>>>>> 2b48908e7ace366e8c5aaeeade1d08293ea13c81
}
