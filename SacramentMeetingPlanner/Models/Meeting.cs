using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Required]
        public string Bishopric { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated")]
        public DateTime DateUpdated { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }

        [Required]
        [Display(Name = "Sacrament Song")]
        public string SacramentSong { get; set; }

        [Required]
        [Display(Name = "First Speaker")]
        // don't know how yet but this need be an array asap
        public string Speaker1 { get; set; }

        [Required]
        [RegularExpression(@"^[0-9A-Za-z\s\-]+$")]
        [Display(Name = "Subject")]
        // so does this
        public string Subject1 { get; set; }

        [Required]
        [Display(Name = "Second Speaker")]
        // don't know how yet but this need be an array asap
        public string Speaker2 { get; set; }

        [Display(Name = "Second Subject")]
        // so does this
        public string Subject2 { get; set; }

        [Display(Name = "Intermediate Song")]
        public string IntermediateSong { get; set; }

        [Display(Name = "Third Speaker")]
        // don't know how yet but this need be an array asap
        public string Speaker3 { get; set; }

        [Display(Name = "Third Subject")]
        // so does this
        public string Subject3 { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
    }
}
