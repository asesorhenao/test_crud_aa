using Inscriptions.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inscriptions.Core.Services
{
    public class InscriptionService
    {
        private readonly IInscriptionRepository _inscritionRepository;
        public InscriptionService(IInscriptionRepository inscriptionRepository)
        {
            _inscritionRepository = inscriptionRepository;
        }
    }
}
