using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class EntradaAlmacenArticuloDM
    {
        public Guid IdEntrada { get; set; }

        public string CodBarras { get; set; }

        public decimal CantidadEntrada { get; set; }

        public decimal CantidadPieza { get; set; }

        public decimal CantidadRegalo { get; set; }

        public decimal Costo { get; set; }

        public bool IsPza { get; set; }

        public ArticuloDM Articulo { get; set; }
    }
}
