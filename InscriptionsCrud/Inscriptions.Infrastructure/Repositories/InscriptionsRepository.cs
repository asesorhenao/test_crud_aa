using Inscriptions.Core.Entities;
using Inscriptions.Core.Interfaces;
using Inscriptions.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inscriptions.Infrastructure.Repositories
{
    public class InscriptionsRepository : IInscriptionRepository
    {
        private readonly inscriptionsCrudContext _context;
        public InscriptionsRepository(inscriptionsCrudContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TblInscriptions>> GetInscriptions()
        {
            var inscriptions = await _context.TblInscriptions.ToListAsync();
            return inscriptions;
        }
    }
}
