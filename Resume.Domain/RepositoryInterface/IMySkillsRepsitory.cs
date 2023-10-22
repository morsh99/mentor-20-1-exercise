using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
    public interface IMySkillsRepsitory
    {
        //GetListOfMySkills
        List<MySkills> GetListOfMySkills();

        Task AddMySkillToDataBase(MySkills mySkill);

        //Task<MySkills> GetMySkillByIdAsync(int mySkillId);

        //Task EditMySkill(MySkills mySkill);

        //Task DeleteMySkill(MySkills mySkill);
    }
}
