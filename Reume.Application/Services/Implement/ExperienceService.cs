using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.Experience;
using Reume.Application.DTOs.AdminSide.Experince;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class ExperienceService : IExperienceService
{
    #region Ctor

    private readonly IExperienceRepository _experienceRepository;

    public ExperienceService(IExperienceRepository experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    #endregion

    public List<Experience> GetListOfExperience()
    {
        return _experienceRepository.GetListOfExperience();
    }

    public async Task AddExperienceToDataBase(CreateExperienceAdminSideDTO model)
    {
        //object mapping
        Experience experience = new Experience();

        experience.ExperienceTitle = model.ExperienceTitle;
        experience.ExperienceDuration = model.ExperienceDuration;
        experience.Description = model.Description;
        experience.CompanyName = model.CompanyName;
        experience.CompanySite = model.CompanySite;

        //add to database
        await _experienceRepository.AddExperienceToDataBase(experience);
    }
}
