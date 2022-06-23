using APBD8_V2_DK.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Controllers
{
    [Route("Team")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly ITeamDbServices _teamDbService;

        public TeamController(ITeamDbServices teamDbService)
        {
            _teamDbService = teamDbService;
        }

        [HttpGet("{TeamId}")]

        public async Task<IActionResult> Getteam(int TeamId)
        {
            try
            {
                return Ok(await _teamDbService.Getteam());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}
