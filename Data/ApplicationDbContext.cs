using AddressBookV2MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookV2MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
