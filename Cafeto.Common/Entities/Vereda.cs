using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        [DisplayName("Fincas")]
        public int Numerofincas => Fincas == null ? 0 : Fincas.Count;
    }
}
