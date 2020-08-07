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

        public async Task InsertInscription(Core.Entities.Inscription inscription)
        {
            _context.Inscriptions.Add(inscription);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateInscription(Inscription inscription) 
        {
            var currentPost = await GetInscription((int)inscription.RegistrationId);
            currentPost.LastName = inscription.LastName;
            currentPost.ExpeditionCity = inscription.ExpeditionCity;
            currentPost.BirthCity = inscription.BirthCity;
            currentPost.ExpeditionDepartment = inscription.ExpeditionDepartment;
            currentPost.BirthDepartment = inscription.BirthDepartment;
            currentPost.Direcction = inscription.Direcction;
            currentPost.Email = inscription.Email;
            currentPost.CivilStatus = inscription.CivilStatus;
            currentPost.ExpeditionDate = inscription.ExpeditionDate;
            currentPost.BirthDate = inscription.BirthDate;
            currentPost.BloodType = inscription.BloodType;
            currentPost.Modality = inscription.Modality;
            currentPost.FirstName = inscription.FirstName;
            currentPost.CellphoneNumber = inscription.CellphoneNumber;
            currentPost.DocumentNumber = inscription.DocumentNumber;
            currentPost.TelephoneNumber = inscription.TelephoneNumber;
            currentPost.ExpeditionCountry = inscription.ExpeditionCountry;
            currentPost.BirthCountry = inscription.BirthCountry;
            currentPost.AcademicPeriod = inscription.AcademicPeriod;
            currentPost.Program = inscription.Program;
            currentPost.Campus = inscription.Campus;
            currentPost.Sex = inscription.Sex;
            currentPost.ApplicantType = inscription.ApplicantType;
            currentPost.DocumentType = inscription.DocumentType;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteInscription(int id)
        {
            var currentInscription = await GetInscription(id);
            _context.Inscriptions.Remove(currentInscription);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}

