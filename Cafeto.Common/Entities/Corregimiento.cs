using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cafeto.Common.Entities
{
    public class Corregimiento
    {
        [Key]
        public int Id { get; set; }
                
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        public int CiudadId { get; set; }

        public Ciudad Ciudad { get; set; }

        public ICollection<Vereda> Veredas { get; set; }

        [DisplayName("Veredas")]
        public int Numeroveredas => Veredas == null ? 0 : Veredas.Count;
    }
}
