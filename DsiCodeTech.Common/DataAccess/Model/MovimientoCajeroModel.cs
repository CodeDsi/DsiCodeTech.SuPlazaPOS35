using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Model
{
    public class MovimientoCajeroModel
    {
        public short IdPos { get; set; }

        public string Cajero { get; set; }

        public DateTime FechaVenta { get; set; }

        public string Movimiento { get; set; }

        public string Supervisor { get; set; }

        public string CodBarras { get; set; }

        public string Descripcion { get; set; }

        public decimal CantidadUM { get; set; }

        public string TipoArticulo { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Descuento { get; set; }

        public decimal PrecioRegular { get; set; }

        public decimal PrecioVenta { get; set; }

    }
}
