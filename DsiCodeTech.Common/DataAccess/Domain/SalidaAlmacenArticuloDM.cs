using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class SalidaAlmacenArticuloDM
    {
        public Guid IdSalida { get; set; }

        public string CodBarras { get; set; }

        public decimal CantidadSalida { get; set; }

        public decimal CantidadPieza { get; set; }

        public decimal CantidadRegalo { get; set; }

        public decimal Costo { get; set; }

        public bool IsPza { get; set; }

        public ArticuloDM Articulo { get; set; }
    }
}
