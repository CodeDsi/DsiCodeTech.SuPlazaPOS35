using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Common.DataAccess.Domain
{
    public class EmpleadoDM
    {
        public Guid IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get;set; }

        public string ApellidoMaterno { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string FullName() => string.Format("{0} {1} {2}", Nombre, ApellidoPaterno, ApellidoMaterno);
    }
}
