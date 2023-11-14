using DsiCodeTech.Common.DataAccess.Filter.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class UnidadMedidaQuery
    {
        public string Descripcion { get; set; }

        public PageRequest Page { get; set; }
    }
}
