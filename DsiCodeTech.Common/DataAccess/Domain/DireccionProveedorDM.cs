using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class DireccionProveedorDM
    {
        public System.Guid IdProveedor { get; set; }
        public string Calle { get; set; }
        public string NoInt { get; set; }
        public string NoExt { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public short IdEntidad { get; set; }
        public short IdMunicipio { get; set; }
        public string Pais { get; set; }
        public string CodPostal { get; set; }
    }
}
