using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Models.Entities.Education;
using Resume.Presenation.Models.Entities.Experience;
using Reume.Application.DTOs.AdminSide.Education;
using Reume.Application.DTOs.AdminSide.Experince;
using Reume.Application.Services.Implement;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ExperienceController : Controller
    {
        #region Ctor

        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        #endregion

        #region List Of Experience

        [HttpGet]
        public IActionResult ListOfExperiences()
        {
            var model = _experienceService.GetListOfExperience();
            return View(model);
        }

        #endregion

        #region Create Experience

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateExperience(CreateExperienceAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _experienceService.AddExperienceToDataBase(model);

                return RedirectToAction(nameof(ListOfExperiences));
            }

            return View();
        }

        #endregion

        #region Edit An Experience

        [HttpGet]
        public async Task<IActionResult> EditAnExperience(int experienceId)
        {
            #region Get An Experience By Id

            var experience = await _experienceService.GetAnExperienceByIdAsync(experienceId);

            #endregion

            return View(experience);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnExperience(Experience experience)
        {
            #region Update An Experience

            await _experienceService.EditAnExperience(experience);

            return RedirectToAction(nameof(ListOfExperiences));

            #endregion

            return View(experience);
        }

        #endregion

        #region Delete An Experience

        [HttpGet]
        public async Task<IActionResult> DeleteAnExperience(int experienceId)
        {
            #region Get An Education By Id

            var experience = await _experienceService.GetAnExperienceByIdAsync(experienceId);

            #endregion

            return View(experience);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnExperience(Experience experience)
        {
            #region Update An Education

            await _experienceService.DeleteAnExperience(experience);

            return RedirectToAction(nameof(ListOfExperiences));

            #endregion

            return View(experience);
        }
        #endregion
    }
}
