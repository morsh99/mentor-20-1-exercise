using Microsoft.AspNetCore.Mvc;
using Resume.Presenation.Models.Entities.Experience;
using Resume.Presenation.Models.Entities.MySkills;
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

        #region Edit A Skill

        [HttpGet]
        public async Task<IActionResult> EditASkill(int mySkillId)
        {
            #region Get A Skill By Id

            var mySkill = await _mySkillsService.GetASkillByIdAsync(mySkillId);

            #endregion

            return View(mySkill);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditASkill(MySkills mySkill)
        {
            #region Update A Skill

            await _mySkillsService.EditASkill(mySkill);

            return RedirectToAction(nameof(ListOfMySkills));

            #endregion

            return View(mySkill);
        }

        #endregion

        #region Delete A Skill

        [HttpGet]
        public async Task<IActionResult> DeleteASkill(int mySkillId)
        {
            #region Get A Skill By Id

            var mySkill = await _mySkillsService.GetASkillByIdAsync(mySkillId);

            #endregion

            return View(mySkill);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteASkill(MySkills mySkill)
        {
            #region Update A Skill

            await _mySkillsService.DeleteASkill(mySkill);

            return RedirectToAction(nameof(ListOfMySkills));

            #endregion

            return View(mySkill);
        }
        #endregion
    }
}
