using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class VentaQuery
    {
        public short IdPos { get; set; }

        public string UserName { get; set; }

        public string Supervisor { get; set; }

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFin { get; set; }

        public PageRequest Page { get; set; }  
        
    }
}
