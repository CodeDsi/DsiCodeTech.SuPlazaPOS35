using DsiCodeTech.Common.DataAccess.Filter.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Filter.Query
{
    public class EmpleadoQuery
    {
        public string Nombre { get; set; }

        public string APaterno { get; set; }

        public string AMaterno { get; set; }

        public string UserName { get; set; }

        public string TipoUsuario { get; set; }

        public PageRequest Page { get; set; }
    }
}
