using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DsiCodeTech.Common.DataAccess.Domain;

namespace DsiCodeTech.Common.DataAccess.Model
{
    public class AuthenticationModel
    {
        public EmpleadoDM Empleado { get; set; }

        public UsuarioDM Usuario { get; set; }

        public string[] Roles { get; set; }
    }
}
