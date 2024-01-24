using Microsoft.EntityFrameworkCore;

namespace FotoBlog.Data
{
	public class UygulamaDbContext : DbContext
	{
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }
        public DbSet<Gonderi> Gonderiler { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Gonderi>().HasData(
				new Gonderi{Id = 1, ResimYolu = "Manzara.jpg", Baslik = "Batarken güneş ardında tepelerin, veda vakti geldi teletabilerin..." },
				new Gonderi { Id = 2 , Baslik = "Doğada gezerler özgürce, sevilirler sonsuzca", ResimYolu = "Leopar.png" }
				);
		}
	}
}
