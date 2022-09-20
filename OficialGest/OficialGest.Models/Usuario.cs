using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OficialGest.Models
{
    /// <summary>
    /// Usuario Aplicacion
    /// </summary>
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioUnidads = new HashSet<UsuarioUnidad>();
        }

        [Key]
        public int Id { get; set; }
        public string? Usuario1 { get; set; }
        public string? Password { get; set; }
        public int? CodRol { get; set; }

        public virtual ICollection<UsuarioUnidad> UsuarioUnidads { get; set; }
    }
}
