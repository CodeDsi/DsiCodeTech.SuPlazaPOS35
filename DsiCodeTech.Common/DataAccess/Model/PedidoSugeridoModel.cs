using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Domain;

namespace DsiCodeTech.Common.DataAccess.Model
{
    public class PedidoSugeridoModel
    {
        public string CodBarras { get; set; }

        public string CodAnexo { get; set; }

        public string Descripcion { get; set; }

        public string UM { get; set; }

        public decimal UMC { get; set; }

        public decimal Stock { get; set; }

        public decimal Costo { get; set; }

        public decimal ExisCja { get; set; }

        public decimal ExisPza { get; set; }

        public decimal Sugerido { get; set; }

        public List<EstadisticaDM> Estadisticas { get; set; }
    }
}
