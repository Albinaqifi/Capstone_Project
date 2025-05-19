using Capstone_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Capstone_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
