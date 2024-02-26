using Microsoft.EntityFrameworkCore;
using Shared;
namespace BlazorWebAppDemo.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<HamburgerModel> Hamburgers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<HamburgerModel>().HasData(
                new HamburgerModel()
                {
                    Id = 1,
                    Name = "Frisco",
                    Description = "God som fan",
                    Price = 99,
                    ImageUrl = "https://www.max.se/contentassets/c4bc7d0b2980409db9e40bb48906ce8a/68657_hemsida-produkt_friscobbqchipotle_beef-meny_c1_2024_1920x1787px_se_dk_no_pl.jpg?width=1160&sharpen=5&sigma=1,4&threshold=0"
                });
        }
    }
}
