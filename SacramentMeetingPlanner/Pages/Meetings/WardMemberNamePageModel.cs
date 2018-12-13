using SacramentMeetingPlanner.Models;
using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SacramentMeetingPlanner.Pages.Meetings
{
    public class WardMemberNamePageModel : PageModel
    {
        public SelectList WardMemberNameSL { get; set; }

        public void PopulateWardMembersDropDownList(SacramentMeetingPlannerContext _context,
            object selectedWardMember = null)
        {
            var wardMembersQuery = from m in _context.WardMember
                                   orderby m.FirstName // Sort by name.
                                   select m;

            WardMemberNameSL = new SelectList(wardMembersQuery.AsNoTracking(),
                        "ID", "FirstName", selectedWardMember);
        }
    }
}
