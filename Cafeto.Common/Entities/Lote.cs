using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cafeto.Common.Entities
{
    public class Lote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        public int FincaId { get; set; }

        public Finca Finca { get; set; }
    }
}
