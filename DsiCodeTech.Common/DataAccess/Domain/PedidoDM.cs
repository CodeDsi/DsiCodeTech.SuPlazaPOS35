using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class PedidoDM
    {
        public Guid IdPedido { get; set; }

        public Guid IdProveedor { get; set; }

        public long NumPedido { get; set; }

        public string Status { get; set; }

        public short NoDias { get; set; }

        public DateTime FechaPedido { get; set; }

        public DateTime? FechaAutorizado { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public string Plan { get; set; }

        public short Mes { get; set; }

        public short Anio { get; set; }

        public ProveedorDM Proveedor { get; set; }

        public List<PedidoArticuloDM> Articulos { get; set; }
    }
}
