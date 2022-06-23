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

        public async Task<IActionResult> GetMusician(int TeamId)
        {
            try
            {
                return Ok(await _teamDbService.GetTeam(TeamId));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}
