using Microsoft.EntityFrameworkCore;

namespace Teste.Models
{
    public class StoreContext :DbContext
    {
        /*Adicione uma propriedade do tipo DbSet para realizar queries à base de dados utilizando 
        instâncias do tipo Product*/
        public DbSet<Product> products { get; set; }

        /*Adicione uma propriedade do tipo DbSet para realizar queries à base de dados utilizando 
        instâncias do tipo OrderDetail*/

        public DbSet<OrderDetail> orderDetails { get; set; }


        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        /*Sobreponha o método OnConfiguring tendo em conta a connection string do seu servidor 
        de MySQL */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseMySQL("server=localhost;database=orderDetail;" + "user=root;password=password;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /* public int productId { get; set; }
             public string Name { get; set; }
             public string Description { get; set; }
             public int Stock { get; set; }
             public double Price { get; set; } */

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.productId);
                entity.Property(e => e.Name);
                entity.Property(e => e.Description);
                entity.Property(e => e.Stock);
                entity.Property(e => e.Price);
            });

           /* public int orderId { get; set; }
            public IEnumerable<Product> productoList { get; set; }
            public double Amount { get; set; }
            public DateTime OrderDate { get; set; }*/

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(b => b.orderId);
                //entity.HasMany(p => p.productoList);
                entity.HasOne(p => p.productoList);
                entity.Property(b => b.Amount);
                entity.Property(b => b.OrderDate);
            });
        }
    }
}
