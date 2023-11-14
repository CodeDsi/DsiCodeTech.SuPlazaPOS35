using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Filter.Page;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class ProveedorQuery
    {
        public string Rfc { get; set; }

        public string RazonSocial { get; set; }

        public string Email { get; set; }

        public PageRequest Page { get; set; }
    }
}
