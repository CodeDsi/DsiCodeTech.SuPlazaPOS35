using DsiCodeTech.Business.Interface;
using DsiCodeTech.Common.DataAccess.Infraestructure.Contract;
using DsiCodeTech.Repository;
using DsiCodeTech.Repository.Infraestructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DsiCodeTech.Common.Exception;
using DsiCodeTech.Repository.PosCaja;

namespace DsiCodeTech.Business
{
    public class UsuarioBusiness
    {
        #region Declaracion de variables
        private readonly IUnitOfWork unitOfWork;
        private readonly UsuarioRepository usuarioRepository;
        #endregion
        #region Creacion del Constructor
        public UsuarioBusiness(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            usuarioRepository = new UsuarioRepository(unitOfWork);
        }

        public UsuarioBusiness()
        {
            unitOfWork = new UnitOfWork();
            usuarioRepository = new UsuarioRepository(unitOfWork);
            
        }

        #endregion

        #region Metodos de Accion
        /// <summary>
        /// Este metodo s encarga de validar al usuario y password
        /// </summary>
        /// <param name="nombre">nombre del usuario</param>
        /// <param name="password´">password del usuario</param>
        /// <returns>regresa un valor boolean  true/false</returns>
        /// <exception cref="BusinessException"></exception>
        public bool ValidarLogin(string nombre, string password)
        {
            try
            {
                
                if(usuarioRepository.Count() >0)
                {
                    this.usuarioRepository.startTransaction();
                    usuario usuario= usuarioRepository
                        .SingleOrDefaultIncludes(p => p.user_name.Equals(nombre) && p.password.Equals(password),
                        "usuario_permiso", "permiso");
                    if (usuario is not null)
                    {
                        return true;
                    }
                    else {
                        return false;
                    } 
                }
                return nombre.Equals("admin") && password.Equals("admin");
            }
            catch (Exception ex) when (ex is DataException || ex is SqlException)
            {

                throw new BusinessException(Common.Constant.DsiCodeConst.RESULT_WITHEXCPETION_ID, 
                    Common.Constant.DsiCodeConst.RESULT_WITHEXCPETION, ex);
            }
        }
        #endregion

    }
}
