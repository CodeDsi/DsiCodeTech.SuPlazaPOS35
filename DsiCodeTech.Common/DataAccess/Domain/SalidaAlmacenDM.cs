using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class SalidaAlmacenDM
    {
        public Guid Id { get; set; }

        public long NumeroSalida { get; set; }

        public DateTime FechaSalida { get; set; }

        public string Observacion { get; set; }

        public long? IdMovimiento { get; set; }

        public string UserName { get; set; }

        public bool IsCancelada { get; set; }

        public DateTime? FechaCancelacion { get; set; }

        public List<SalidaAlmacenArticuloDM> Articulos { get; set; }
    }
}
