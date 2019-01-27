using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class WardMember
    {
        public int ID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please Enter a name with only alphabet characters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter valid First Name between 2 and 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please Enter a name with only alphabet characters")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please enter valid Last Name between 2 and 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Calling")]
        public string Calling { get; set; }

        [Display(Name = "Bishopric Member?")]
        public string IsBishopric { get; set; }
    }
}
