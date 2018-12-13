using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.WardMembers
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlanner.Models.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public WardMember WardMember { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WardMember = await _context.WardMember.FirstOrDefaultAsync(m => m.ID == id);

            if (WardMember == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
