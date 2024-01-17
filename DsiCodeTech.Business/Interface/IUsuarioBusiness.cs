using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsiCodeTech.Business.Interface
{
    public interface IUsuarioBusiness
    {
        /// <summary>
        /// Este metodo s encarga de validar al usuario y password
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="password´">password del usuario</param>
        /// <returns>regresa un valor boolean  true/false</returns>
        /// <exception cref="BusinessException"></exception>
        bool ValidarLogin(string nombre, string password);
    }
}
