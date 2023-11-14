using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class OfertaArticuloDM
    {
        public Guid IdOferta { get; set; }

        public string CodBarras { get; set; }

        public decimal PrecioOferta { get; set; }

        public string StatusOferta { get; set; }

        public DateTime? FechaCancelacion { get; set; }

        public DateTime FechaRegistro { get; set; }

        public ArticuloDM Articulo { get; set; }
    }
}
