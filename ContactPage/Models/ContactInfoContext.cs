using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactPage.Models
{
    public class ContactInfoContext: DbContext
    {
        public ContactInfoContext (DbContextOptions<ContactInfoContext> options)
            : base(options)
        {

        }

        public DbSet<ContactInfo> ContactInfo { get; set; }
    }
}
