using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.StoreProcedure
{
    public class EstadisticaArticuloPaginacionSP
    {
        public string cod_barras { get; set; }

        public string descripcion { get; set; }

        public string um { get; set; }

        public decimal cantidad { get; set; }

        public decimal cambio_precio { get; set; }

        public decimal articulo_ofertado { get; set; }

        public decimal articulo_normal { get; set; }

        public decimal total_x_cambio { get; set; }

        public decimal total_x_oferta { get; set; }

        public decimal total_x_normal { get; set; }

        public decimal total { get; set; }
    }
}
