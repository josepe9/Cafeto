using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeto.Common.Entities
{
    public class Hectarea
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int Palos { get; set; }

        public DateTime Siembra { get; set; }

        public int Arrobas { get; set; }

        public int KNitrogeno { get; set; }

        public int KPotasio { get; set; }

        public int KFosforo { get; set; }

        public decimal Ph { get; set; }


    }
}
