using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class PedidoArticuloDM
    {
        public Guid IdPedido { get; set; }

        public short NoArticulo { get; set; }

        public string CodBarras { get; set; }

        public string CodAnexo { get; set; }

        public decimal CantOriginal { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioArticulo { get; set; }

        public decimal Sugerido { get; set; }

        public decimal Stock { get; set; }

        public decimal CantCja { get; set; }

        public decimal CantPza { get; set; }

        public ArticuloDM Articulo { get; set; }
    }
}
