using APBD8_V2_DK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Controllers
{
    [Route("hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {

        private readonly IHospitalDbServices _hospitalDbService;

        public HospitalController(IHospitalDbServices hospitalDbService)
        {
            _hospitalDbService = hospitalDbService;
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var result = await _hospitalDbService.GetDoctorsAsync();

            if (result == null)
                return NoContent();

            return Ok(result);
        }

    }
}
