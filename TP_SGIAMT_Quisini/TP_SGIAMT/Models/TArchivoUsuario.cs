using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TArchivoUsuario
    {
        public TArchivoUsuario()
        {
            TUsuario = new HashSet<TUsuario>();
        }

        public int PkIauIdArchivo { get; set; }
        public string VauArchivo { get; set; }

        public ICollection<TUsuario> TUsuario { get; set; }
    }
}
