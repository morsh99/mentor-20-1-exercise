using Microsoft.AspNetCore.Mvc;
using Reume.Application.DTOs.AdminSide.Education;
using Reume.Application.DTOs.AdminSide.Experince;
using Reume.Application.DTOs.AdminSide.MySkills;
using Reume.Application.Services.Implement;
using Reume.Application.Services.Interface;

namespace Resume.Presenation.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MySkillsController : Controller
    {
        #region Ctor

        private readonly IMySkillService _mySkillsService;

        public MySkillsController(IMySkillService mySkillsService)
        {
            _mySkillsService = mySkillsService;
        }

        #endregion

        #region List Of My Skills

        [HttpGet]
        public IActionResult ListOfMySkills()
        {
            var model = _mySkillsService.GetListOfMySkills();
            return View(model);
        }

        #endregion

        #region Create Skill

        [HttpGet]
        public IActionResult CreateMySkill()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMySkill(CreateSkillAdminSideDTO model)
        {
            if (ModelState.IsValid)
            {
                await _mySkillsService.AddSkillToDataBase(model);

                return RedirectToAction(nameof(ListOfMySkills));
            }

            return View();
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}
