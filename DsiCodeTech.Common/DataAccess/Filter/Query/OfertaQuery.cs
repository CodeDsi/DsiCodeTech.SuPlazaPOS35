using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class OfertaQuery
    {
        public string Descripcion { get; set; }

        public string StatusOferta { get; set; }

        public PageRequest Page { get; set; }
    }
}
