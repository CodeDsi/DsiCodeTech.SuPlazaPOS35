using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class OfertaDM
    {
        public Guid IdOferta { get; set; }

        public long NumOferta { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaOferta { get; set; }

        public DateTime FechaInicial { get; set; }

        public DateTime FechaFin { get; set; }

        public string StatusOferta { get; set; }

        public DateTime? FechaCancelacion { get; set; }

        public string UserName { get; set; }

        public List<OfertaArticuloDM> Articulos { get; set; }
    }
}
