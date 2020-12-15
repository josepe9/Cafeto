using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cafeto.Common.Entities
{
    public class Finca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string Propietario { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [Required]
        public int VeredaId { get; set; }

        public int Hectareas { get; set; }

        public Vereda Vereda { get; set; }

        public ICollection<Lote> Lotes { get; set; }
    }
}
