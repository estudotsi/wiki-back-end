using Microsoft.EntityFrameworkCore;
using WikiGC.Data;
using WikiGC.Models;
using WikiGC.Repositories.Interface;

namespace WikiGC.Repositories.Repository
{
    public class PortaisRepository : IPortaisRepository
    {
        private readonly DataContext _context;

        public PortaisRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Portais> AddPortal(Portais portal)
        {
            await _context.Portais.AddAsync(portal);
            await _context.SaveChangesAsync();

            return portal;
        }

        public async Task<Portais> DeletePortal(int idPortal)
        {
            //Portais portalFind = await GetoPortalById(idPortal);
            Portais portalFind = await _context.Portais.FirstOrDefaultAsync(x => x.Id == idPortal);
            if (portalFind == null)
            {
                throw new Exception($"Portal{idPortal} não foi localizado");
            }

            _context.Portais.Remove(portalFind);
            await _context.SaveChangesAsync();

            return portalFind;
        }

        public async Task<Portais> GetoPortalById(int idPortal)
        {
            Portais portalFind = await _context.Portais.FirstOrDefaultAsync(x => x.Id == idPortal);
            if (portalFind == null)
            {
                throw new Exception($"Portal{idPortal} não foi localizado");
            }

            return portalFind;
        }

        public async Task<List<Portais>> GetPortais()
        {
            return await _context.Portais.ToListAsync();
        }

        public async Task<Portais> UpdatePortal(Portais portal, int idPortal)
        {

            //Portais portalFind = await GetoPortalById(idPortal);
            Portais portalFind = await _context.Portais.FirstOrDefaultAsync(x => x.Id == idPortal);
            if (portalFind == null) 
            {
                throw new Exception($"Portal{idPortal} não foi localizado");
            }
            portalFind.Nome = portal.Nome;
            portalFind.UrlProducao = portal.UrlProducao;
            portalFind.ServidorProducao = portal.ServidorProducao;
            portalFind.VersaoWordpressProducao = portal.VersaoWordpressProducao;
            portalFind.UrlHomologacao = portal.UrlHomologacao;
            portalFind.ServidorHomologacao = portal.ServidorHomologacao;
            portalFind.VersaoWordpressHomologacao = portal.VersaoWordpressHomologacao;
            portalFind.Responsavel = portal.Responsavel;

            _context.Portais.Update(portalFind);
            await _context.SaveChangesAsync();

            return portalFind;

        }
       
    }
}
