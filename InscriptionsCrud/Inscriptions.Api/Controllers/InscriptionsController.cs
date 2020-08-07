using AutoMapper;
using Inscriptions.Api.Responses;
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
            var response = new ApiResponse<IEnumerable<InscriptionDto>>(inscriptionsDto);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetInscription(int id)
        {
            var inscription = await _inscriptionRepository.GetInscription(id);
            var inscriptionDto = _mapper.Map<InscriptionDto>(inscription);
            var response = new ApiResponse<InscriptionDto>(inscriptionDto);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(InscriptionDto inscriptionDto)
        {
            var inscription = _mapper.Map<Inscription>(inscriptionDto);
            await _inscriptionRepository.InsertInscription(inscription);
            inscriptionDto = _mapper.Map<InscriptionDto>(inscription);
            var response = new ApiResponse<InscriptionDto>(inscriptionDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, InscriptionDto inscriptionDto)
        {
            var inscription = _mapper.Map<Inscription>(inscriptionDto);
            inscription.RegistrationId = id;
            var result = await _inscriptionRepository.UpdateInscription(inscription);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _inscriptionRepository.DeleteInscription(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
        }
    }
}
