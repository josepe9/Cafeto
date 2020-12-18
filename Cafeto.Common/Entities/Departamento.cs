using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cafeto.Common.Entities
{
    public class Departamento
    {
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }
        [Required]
        [StringLength(40)]
        [MaxLength(40, ErrorMessage = "El {0} no puede contener más de {1} caracteres")]
        public string Nombre { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
