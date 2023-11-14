using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class PedidoQuery
    {
        public Guid? IdProveedor { get; set; }

        public string Estatus { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public PageRequest Page { get; set; }
    }
}
