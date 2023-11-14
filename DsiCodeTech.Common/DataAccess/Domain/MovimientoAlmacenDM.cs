using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class MovimientoAlmacenDM
    {
        public long IdMovimiento { get; set; }

        public string Descripcion { get; set; }

        public string TipoMovimiento { get; set; }
    }
}
