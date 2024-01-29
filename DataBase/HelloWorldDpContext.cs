using Microsoft.EntityFrameworkCore;


namespace HelloWorld.DataBase
{
    public class HelloWorldDpContext : DbContext
    {
        public HelloWorldDpContext(DbContextOptions<HelloWorldDpContext> options) : base(options)
        {

        }

        public DbSet<Datas> Datas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Datas>().ToTable("Datas");
        }
    }


}
