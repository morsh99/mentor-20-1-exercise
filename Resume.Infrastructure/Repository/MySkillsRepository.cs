using Microsoft.EntityFrameworkCore;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.MySkills;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class MySkillsRepository : IMySkillsRepsitory
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public MySkillsRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<MySkills> GetListOfMySkills()
        {
            return _context.MySkills.ToList();  
        }

        public async Task AddMySkillToDataBase(MySkills mySkill)
        {
            await _context.MySkills.AddAsync(mySkill);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMySkill(MySkills mySkill)
        {
            _context.MySkills.Remove(mySkill);
            await _context.SaveChangesAsync();
        }

        public async Task EditMySkill(MySkills mySkill)
        {
            _context.MySkills.Update(mySkill);
            await _context.SaveChangesAsync();
        }

        public Task<MySkills> GetMySkillByIdAsync(int mySkillId)
        {
            return _context.MySkills.FirstOrDefaultAsync(p => p.Id == mySkillId);
        }
    }
}
