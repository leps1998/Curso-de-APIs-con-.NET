using Microsoft.EntityFrameworkCore;
using TareaTema2.Models.DataModels;

namespace TareaTema2.DataAccess
{
    public class TareaTema2DBContext : DbContext
    {
        public TareaTema2DBContext(DbContextOptions<TareaTema2DBContext> options) : base(options)
        {

        }

        //Add DbSets (Tables of our Data base)
        public DbSet<User>? Users { get; set; }
    }
}
