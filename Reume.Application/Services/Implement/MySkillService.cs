using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.MySkills;
using Reume.Application.DTOs.AdminSide.MySkills;
using Reume.Application.Services.Interface;

namespace Reume.Application.Services.Implement;

public class MySkillService : IMySkillService
{
	#region Ctor

	private readonly IMySkillsRepsitory _mySkillsRepsitory;

    public MySkillService(IMySkillsRepsitory mySkillsRepsitory)
    {
        _mySkillsRepsitory = mySkillsRepsitory;
    }

    #endregion

    public List<MySkills> GetListOfMySkills()
    {
        return _mySkillsRepsitory.GetListOfMySkills();
    }

    public async Task AddSkillToDataBase(CreateSkillAdminSideDTO model)
    {
        MySkills mySkill = new MySkills();

        mySkill.SkillTille = model.SkillTille;
        mySkill.Percentage = model.Percentage;

        //add to database 
        await _mySkillsRepsitory.AddMySkillToDataBase(mySkill);
    }
}
