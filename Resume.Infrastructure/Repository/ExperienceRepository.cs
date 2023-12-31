﻿using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        #region Ctor

        private readonly ResumeDbContext _context;

        public ExperienceRepository(ResumeDbContext context)
        {
            _context = context;
        }

        #endregion

        public List<Experience> GetListOfExperience()
        {
            return _context.Experiences.ToList();
        }

        public async Task AddExperienceToDataBase(Experience experience)
        {
            await _context.Experiences.AddAsync(experience);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnExperience(Experience experience)
        {
            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
        }

        public async Task EditAnExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            await _context.SaveChangesAsync();
        }

        public Task<Experience> GetAnExperienceByIdAsync(int experienceId)
        {
            return _context.Experiences.FirstOrDefaultAsync(p => p.Id == experienceId);
        }
    }
}
