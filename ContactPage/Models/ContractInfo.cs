using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContactPage.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
    }
}
