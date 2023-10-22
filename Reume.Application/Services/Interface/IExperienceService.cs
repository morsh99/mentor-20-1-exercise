using Resume.Presenation.Models.Entities.Experience;
using Reume.Application.DTOs.AdminSide.Education;
using Reume.Application.DTOs.AdminSide.Experince;

namespace Reume.Application.Services.Interface;

public interface IExperienceService
{
    //GetListOfExperience
    List<Experience> GetListOfExperience();

    Task AddExperienceToDataBase(CreateExperienceAdminSideDTO model);
}
