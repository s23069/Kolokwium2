using APBD8_DK.Models;
using APBD8_V2_DK.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Services
{
    public class HospitalDbServices
    {
        private readonly MainDbContext _context;

        public HospitalDbServices (MainDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DoctorDTO>> GetDoctorsAsync()
        {


            return await _context.Doctors.Select(e => new DoctorDTO
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email
            }).ToListAsync();
        }
    
    }
}
