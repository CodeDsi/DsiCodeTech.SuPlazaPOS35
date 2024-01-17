using DsiCodeTech.Business.Interface;
using DsiCodeTech.Common.DataAccess.Infraestructure.Contract;
using DsiCodeTech.Repository;
using DsiCodeTech.Repository.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
