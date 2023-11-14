using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Domain;

namespace DsiCodeTech.Common.DataAccess.Model
{
    public class PedidoDetalleModel
    {
        public PedidoDM Pedido { get; set; }

        public List<PedidoSugeridoModel> Sugeridos { get; set; }
    }
}
