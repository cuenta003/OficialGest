using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OficialGest.Models
{
    public partial class Unidad
    {
        public Unidad()
        {
            UsuarioUnidads = new HashSet<UsuarioUnidad>();
        }

        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int? IdPadre { get; set; }

        public virtual ICollection<UsuarioUnidad> UsuarioUnidads { get; set; }
    }
}
