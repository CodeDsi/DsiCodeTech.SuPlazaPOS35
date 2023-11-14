using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class InventarioFisicoArticuloDM
    {
        public Guid IdInventario { get; set; }

        public string CodBarras { get; set; }

        public decimal StockEstimado { get; set; }

        public decimal StockFisico { get; set; }

        public decimal CantCja { get; set; }

        public decimal CantPza { get; set; }

        public ArticuloDM Articulo { get; set; }
    }
}
