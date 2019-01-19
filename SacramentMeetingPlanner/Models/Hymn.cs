using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Hymn
    {
        public int HymnID { get; set; }

        [RegularExpression(@"^[0-9A-Za-z\s\-]+$")]
        [Required]
        public string Title { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
