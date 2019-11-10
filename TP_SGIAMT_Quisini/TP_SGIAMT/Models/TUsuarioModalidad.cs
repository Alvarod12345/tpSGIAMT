using System;
using System.Collections.Generic;

namespace TP_SGIAMT.Models
{
    public partial class TUsuarioModalidad
    {
        public int? FkIuDni { get; set; }
        public int? FkImIdModalidad { get; set; }
        public int PkIumCodUm { get; set; }
        public int? FkIcIdConcurso { get; set; }

        public TConcurso FkIcIdConcursoNavigation { get; set; }
        public TModalidadCon FkImIdModalidadNavigation { get; set; }
        public TUsuario FkIuDniNavigation { get; set; }
    }
}
