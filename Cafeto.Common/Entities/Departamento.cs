using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cafeto.Common.Entities
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
