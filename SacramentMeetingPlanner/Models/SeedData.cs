using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                // Look for any meetings.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    /*
                    // Meeting Template
                    new Meeting
                    {
                        MeetingDate = DateTime.Parse(""),
                        DateUpdated = DateTime.Now,
                        Bishopric = "",
                        OpeningPrayer = "",
                        ClosingPrayer = "",
                        OpeningSong = "",
                        SacramentSong = "",
                        IntermediateSong = "",
                        ClosingSong = "",
                        Speaker = "",
                        Subject = "",
                    }
                    */

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("1981-11-15"),
                        DateUpdated = DateTime.Now,
                        Bishopric = "Billy Bob",
                        OpeningPrayer = "Adam Smith",
                        ClosingPrayer = "Old McDude",
                        OpeningSong = "#426 Don't Hit People",
                        SacramentSong = "#865 People Did Nice Things",
                        ClosingSong = "#567 Undying Love ",
                        Speaker = "Thing 1",
                        Subject = "Stuff 1",
                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}