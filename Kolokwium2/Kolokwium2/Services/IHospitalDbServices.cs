using APBD8_V2_DK.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBD8_V2_DK.Services
{
    public interface IHospitalDbServices
    {
           
        Task<IEnumerable<DoctorDTO>> GetDoctorsAsync();
        Task<string> AddDoctorAsync(DoctorDTO dto);
        Task<string> ChangeDoctorAsync(int id, DoctorDTO dto);
        Task<string> DeleteDoctorAsync(int id);
       // Task<PrescriptionDTO> GetPrescriptionAsync(int id);
    }
}

