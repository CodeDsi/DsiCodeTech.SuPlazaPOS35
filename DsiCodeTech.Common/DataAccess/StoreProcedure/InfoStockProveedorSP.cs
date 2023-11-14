using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.StoreProcedure
{
    public class InfoStockProveedorSP
    {
        public string cod_barras { get; set; }

        public string cod_anexo { get; set; }

        public string descripcion { get; set; }

        public string um { get; set; }

        public decimal umc { get; set; }

        public decimal costo { get; set; }

        public decimal stock { get; set; }
    }
}
