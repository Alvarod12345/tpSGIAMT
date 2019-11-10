using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;



namespace TP_SGIAMT.Models
{
    [AllowAnonymous]
    public partial class TUsuario
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly ILogger<TUsuario> _logger;

        [BindProperty]
        public TUsuario Input { get; set; }

        //public TUsuario(SignInManager<IdentityUser> signInManager, ILogger<TUsuario> logger)
        //{
        //    _signInManager = signInManager;
        //    _logger = logger;
        //}

        [TempData]
        public String ErrorMessage { get; set; }
        //public TUsuario()
        //{
        //    TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        //} 

        //--------------DNI-------------------
        [Required(ErrorMessage = "<font color='black'>El campo DNI es obligatorio!</font>")]
        public int Dni { get; set; }
        //---------------------------------
        //-------------Pass--------------------
        [Required(ErrorMessage = "<font color='black'>Contraseña es obligatorio!</font>")]
        [DataType(DataType.Password)]
        public string Contra { get; set; }
        //---------------------------------
        [Display(Name = "Remember me")]
        public bool Rememberme { get; set; }
        //--------------DNI-------------------
        [Required(ErrorMessage = "<font color='red'>El campo DNI es obligatorio!</font>")]
        //[StringLength(100, ErrorMessage = "<font color='red'>El numero de caracteres de {0} debe ser al " +
        //    "menos {2}.</font>", MinimumLength = 8)]
        public int PkIuDni { get; set; }
        //---------------------------------

        //-------------Pass--------------------
        [Required(ErrorMessage = "<font color='red'>Contraseña es obligatorio!</font>")]
        [DataType(DataType.Password)]
        public string VuContraseña { get; set; }
        //---------------------------------

        public string VuNombre { get; set; }
        public string VuApaterno { get; set; }
        public string VuAmaterno { get; set; }
        public DateTime? DuFechaNacimiento { get; set; }

        public string VuSexo { get; set; }
        public string VuNacademia { get; set; }
        public int? FkIuCodCategoria { get; set; }
        public int? FkItuTipoUsuario { get; set; }
        public int? FkIauIdArchivo { get; set; }

        public TArchivoUsuario FkIauIdArchivoNavigation { get; set; }
        public TTipoUsuario FkItuTipoUsuarioNavigation { get; set; }
        public TCategoria FkIuCodCategoriaNavigation { get; set; }
        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
    }
}
