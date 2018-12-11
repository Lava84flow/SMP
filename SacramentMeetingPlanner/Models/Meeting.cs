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

        public string Bishopric { get; set; }  

        [DataType(DataType.Date)]
        public DateTime UpdatedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        public string Song { get; set; }

        public string Prayers { get; set; }

        public string Speaker { get; set; }
        
        public string Subject { get; set; }

    }
}
