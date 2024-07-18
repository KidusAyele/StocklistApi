using Microsoft.EntityFrameworkCore;
namespace StocklistApi.Models
{
	public class StocklistContext : DbContext
	{
        public StocklistContext(DbContextOptions<StocklistContext> options):base(options)
        {

           
        }
        public DbSet <Items>Items { get; set; }
    }
}
