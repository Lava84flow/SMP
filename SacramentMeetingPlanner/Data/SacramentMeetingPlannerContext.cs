using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeetingPlannerContext : DbContext
    {
        public SacramentMeetingPlannerContext (DbContextOptions<SacramentMeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner.Models.Meeting> Meeting { get; set; }
        public DbSet<SacramentMeetingPlanner.Models.WardMember> WardMember { get; set; }
        public DbSet<SacramentMeetingPlanner.Models.Hymn> Hymn { get; set; }
    }
}
