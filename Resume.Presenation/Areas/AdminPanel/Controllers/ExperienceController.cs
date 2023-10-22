using Microsoft.AspNetCore.Mvc;
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

    }
}
