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
        public async Task<IEnumerable<Core.Entities.Inscription>> GetInscriptions()
        {
            var inscriptions = await _context.Inscriptions.ToListAsync();
            return inscriptions;
        }

        public async Task<Core.Entities.Inscription> GetInscription(int id)
        {
            var inscription = await _context.Inscriptions.FirstOrDefaultAsync(x=> x.RegistrationId == id);
            return inscription;
        }

        public async Task InsertPost(Core.Entities.Inscription post)
        {
            _context.Inscriptions.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
