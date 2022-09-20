using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OficialGest.Models
{
    public partial class UsuarioUnidad
    {
        [Key]
        public int Id { get; set; }
        public int? CodUsuario { get; set; }
        public int? CodUnidad { get; set; }

        public virtual Unidad? CodUnidadNavigation { get; set; }
        public virtual Usuario? CodUsuarioNavigation { get; set; }
    }
}
