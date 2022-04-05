using Microsoft.EntityFrameworkCore;

namespace DigitalCommons.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Models.DigitalModel.Student> Students { get; set; }

        public DbSet<Models.DigitalModel.Document> Documents { get; set; }

        public DbSet<Models.DigitalModel.UserInfo> userInfos { get; set; }

        public DbSet<Models.DigitalModel.DownloadInfo> downloadInfos { get; set; }
    }
}
