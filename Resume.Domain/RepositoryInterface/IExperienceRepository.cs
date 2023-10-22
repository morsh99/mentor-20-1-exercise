using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.Entities.Experience;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperienceRepository
    {
        //GetListOfExperiences
        List<Experience> GetListOfExperience();

        Task AddExperienceToDataBase(Experience experience);

        //Task<Experience> GetExperienceByIdAsync(int experienceId);

        //Task EditExperience(Experience experience);

        //Task DeleteExperience(Experience experience);
    }
}
