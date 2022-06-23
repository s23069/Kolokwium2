using APBD8_V2_DK.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Services
{
    public interface ITeamDbServices
    {
           
         Task<IEnumerable<TeamDTO>> Getteam();
     
       
    }
}

