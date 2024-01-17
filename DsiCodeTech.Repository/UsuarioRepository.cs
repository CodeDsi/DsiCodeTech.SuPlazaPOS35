using DsiCodeTech.Common.DataAccess.Infraestructure;
using DsiCodeTech.Common.DataAccess.Infraestructure.Contract;
using DsiCodeTech.Repository.PosCaja;

namespace DsiCodeTech.Repository
{
    public class UsuarioRepository : BaseRepository<usuario>
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
    }
}
