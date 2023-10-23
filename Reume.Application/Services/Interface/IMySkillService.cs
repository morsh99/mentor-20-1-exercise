using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;
using Reume.Application.DTOs.AdminSide.Experince;
using Reume.Application.DTOs.AdminSide.MySkills;

namespace Reume.Application.Services.Interface;

public interface IMySkillService
{
    //GetListOfMySkills
    List<MySkills> GetListOfMySkills();

    Task AddSkillToDataBase(CreateSkillAdminSideDTO model);

    Task<MySkills> GetASkillByIdAsync(int mySkillId);

    Task EditASkill(MySkills mySkills);

    Task DeleteASkill(MySkills mySkills);
}
