using Inscriptions.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inscriptions.Core.Interfaces
{
    public interface IInscriptionRepository
    {
        Task<IEnumerable<Entities.Inscription>> GetInscriptions();
        Task<Entities.Inscription> GetInscription(int id);
        Task InsertPost(Entities.Inscription post);
    }
}
