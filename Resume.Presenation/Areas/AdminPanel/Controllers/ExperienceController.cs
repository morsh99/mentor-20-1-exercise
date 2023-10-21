using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
