using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity.UI.Services;




namespace TP_SGIAMT.Models
{
    public class login
    {
      

        [TempData]
        public String ErrorMessage { get; set; }

        //--------------DNI-------------------
        [Required(ErrorMessage = "<font color='black'>El campo DNI es obligatorio!</font>")]
        public int  Dni{ get; set; }
        //---------------------------------
        //-------------Pass--------------------
        [Required(ErrorMessage = "<font color='black'>Contraseña es obligatorio!</font>")]
        [DataType(DataType.Password)]
        public string Contra{ get; set; }
        //---------------------------------
        [Display(Name = "Remember me")]
        public bool Rememberme { get; set; }
    }
}
