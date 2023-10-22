using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reume.Application.DTOs.AdminSide.Experince
{
    public class CreateExperienceAdminSideDTO
    {
        public string ExperienceTitle { get; set; }

        public string ExperienceDuration { get; set; }

        public string Description { get; set; }

        public string CompanyName { get; set; }

        public string? CompanySite { get; set; }
    }
}
