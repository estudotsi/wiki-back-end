using WikiGC.Controllers;
using WikiGC.Models;

namespace WikiGC.Repositories.Interface
{
    public interface IPortaisRepository
    {
        Task<List<Portais>> GetPortais();
        Task<Portais> GetoPortalById(int idPortal);
        Task<Portais> AddPortal(Portais portal);
        Task<Portais> UpdatePortal(Portais portal, int portalId);
        Task<Portais> DeletePortal(int idPortal);
    }
}
