using AutoMapper;
using Inscriptions.Core.DTOs;
using Inscriptions.Core.Entities;
using Inscriptions.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inscriptions.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscriptionsController : ControllerBase
    {
        private readonly IInscriptionRepository _inscriptionRepository;
        private readonly IMapper _mapper;
        public InscriptionsController(IInscriptionRepository inscriptionRepository, IMapper mapper)
        {
            _inscriptionRepository = inscriptionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetInscriptions()
        {
            var inscriptions = await _inscriptionRepository.GetInscriptions();
            var inscriptionsDto = _mapper.Map <IEnumerable<InscriptionDto>>(inscriptions);
            return Ok(inscriptionsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInscription(int id)
        {
            var inscription = await _inscriptionRepository.GetInscription(id);
            var inscriptionDto = _mapper.Map<InscriptionDto>(inscription);
            return Ok(inscriptionDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InscriptionDto inscriptionDto)
        {
            var inscription = _mapper.Map<Inscription>(inscriptionDto);
            await _inscriptionRepository.InsertPost(inscription);
            return Ok(inscription);
        }
    }
}
