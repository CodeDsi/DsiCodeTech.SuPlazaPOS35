using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class PermisoDM
    {
        public string IdPermiso { get; set; }
        public string Descripcion { get; set; }
        public string TipoSistema { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
