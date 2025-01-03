using All_Social_media_apps_apis.Models;
using Microsoft.EntityFrameworkCore;

namespace All_Social_media_apps_apis.DataBase
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options):base(options)
        {
            
        }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<Gmail> Gmails { get; set; }
    }
}
