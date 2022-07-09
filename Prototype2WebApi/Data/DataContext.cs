using Microsoft.EntityFrameworkCore;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<UserInfoData> UserInfoDatas { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
