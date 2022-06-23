using APBD8_DK.Models;
using APBD8_V2_DK.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Services
{
    public class TeamDbServices:ITeamDbServices
    {
        private readonly MainDbContext _context;

        public TeamDbServices (MainDbContext context)
        {
            _context = context;
        }



        

        public async Task<IEnumerable<TeamDTO>> Getteam()
        {
            return await _context.Teams.Select(e => new TeamDTO
            {
                TeamId = (int)e.TeamId,
                TeamName = e.TeamName,
                teamDescription = e.TeamDescription,

            }).ToListAsync();
        }

        //public Task<IEnumerable<TeamDTO>> Getteam()
        //{
        //    return await _context.Teams.Select(e => new TeamDTO
        //    {
        //        TeamId = (int)e.TeamId,
        //        TeamName = e.TeamName,
        //        teamDescription = e.TeamDescription,

        //    }).ToListAsync();
        //}
    }
}
