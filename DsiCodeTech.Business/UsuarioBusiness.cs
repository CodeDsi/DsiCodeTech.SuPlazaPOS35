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
        public bool ValidarLogin(string nombre, string password)
        {
            try
            {

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
