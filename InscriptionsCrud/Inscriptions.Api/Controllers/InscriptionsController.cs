using Inscriptions.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inscriptions.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscriptionsController : ControllerBase
    {
        private readonly IInscriptionRepository _inscriptionRepository;
        public InscriptionsController(IInscriptionRepository inscriptionRepository)
        {
            _inscriptionRepository = inscriptionRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetInscriptions()
        {
            var inscriptions = await _inscriptionRepository.GetInscriptions();
            return Ok(inscriptions);
        }
    }
}
