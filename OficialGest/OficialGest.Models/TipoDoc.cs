using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OficialGest.Models
{
    public partial class TipoDoc
    {
        [Key]
        public int Id { get; set; }
        public int? Descripcion { get; set; }
    }
}
