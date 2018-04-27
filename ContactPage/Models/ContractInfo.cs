using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactPage.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phoneNumber { get; set; }
        [Required]
        public string emailAddress { get; set; }
    }
}
