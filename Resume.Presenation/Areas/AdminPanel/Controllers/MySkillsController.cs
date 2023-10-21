using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
