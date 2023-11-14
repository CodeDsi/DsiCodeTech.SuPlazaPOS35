using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class SalidaAlmacenQuery
    {
        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public string Observacion { get; set; }

        public long IdMovimiento { get; set; }

        public PageRequest Page { get; set; }
    }
}
