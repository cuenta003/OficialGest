using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OficialGest.Models
{
    public partial class DocUnidad
    {

        [Key]
        public int Id { get; set; }
        public int? CodTipoDoc { get; set; }
        public int? CodUnidad { get; set; }
        public string? Mascara { get; set; }
        public int? Correlativo { get; set; }
        public bool? Autoreset { get; set; }
        public string? Pantilla { get; set; }
    }
}
