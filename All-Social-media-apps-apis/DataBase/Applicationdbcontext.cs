using Microsoft.EntityFrameworkCore;

namespace All_Social_media_apps_apis.DataBase
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options):base(options)
        {
            
        }
    }
}
