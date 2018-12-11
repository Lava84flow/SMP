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
        public string OpeningPrayer { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateUpdated { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }


        [Required]
        public string OpeningSong { get; set; }

        [Required]
        public string SacramentSong { get; set; }

        //optional
        public string IntermediateSong { get; set; }

        [Required]
        public string ClosingSong { get; set; }

        [Required]
        public string ClosingPrayer { get; set; }

        // don't know how yet but this need be an array asap
        public string Speaker { get; set; }
        
        // so does this
        public string Subject { get; set; }

    }
}
