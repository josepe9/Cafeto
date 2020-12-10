using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cafeto.Common.Entities
{
    public class Vereda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        public int CorregimientoId { get; set; }

        public Corregimiento Corregimiento { get; set; }

        public ICollection<Finca> Fincas { get; set; }
    }
}
