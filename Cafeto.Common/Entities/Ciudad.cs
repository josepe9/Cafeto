using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cafeto.Common.Entities
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }
       
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set; }

        public ICollection<Corregimiento> Corregimientos { get; set; }

        [DisplayName("Corregimientos")]
        public int NCorregimientos => Corregimientos == null ? 0 : Corregimientos.Count;
    }
}
