namespace API.Data
{
    public class DataContext
    {
                public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 11, ProductName = "Burger", Price = 10.00, ValidFrom = "2020-10-10", ValidTo = "2020-10-15" },
                    new Product { Id = 12, ProductName = "Shaorma", Price = 19.00, ValidFrom = "2020-10-20", ValidTo = "2020-11-01" },
                    new Product { Id = 13, ProductName = "BurgerKing", Price = 30.00, ValidFrom = "2020-10-20", ValidTo = "2020-10-30" },
                    new Product { Id = 14, ProductName = "BurgerQueen", Price = 40.00, ValidFrom = "2020-10-15", ValidTo = "2020-10-30" },
                    new Product { Id = 15, ProductName = "BurgerMicut", Price = 20.00, ValidFrom = "2020-10-15", ValidTo = "2020-11-10" },
                    new Product { Id = 16, ProductName = "BurgerMaiMicut", Price = 20.00, ValidFrom = "2020-10-15", ValidTo = "2020-11-05" },
                    new Product { Id = 17, ProductName = "BurgerCuShaorma", Price = 30.00, ValidFrom = "2020-10-11", ValidTo = "2020-11-05" },
                    new Product { Id = 18, ProductName = "BurgerCuSalata", Price = 20.00, ValidFrom = "2020-10-10", ValidTo = "2020-11-15" },
                    new Product { Id = 19, ProductName = "ShaormaCuSalata", Price = 20.00, ValidFrom = "2020-10-25", ValidTo = "2020-11-02" },
                    new Product { Id = 20, ProductName = "VeganBurger", Price = 30.00, ValidFrom = "2020-10-15", ValidTo = "2020-11-03" }
                );
            
            modelBuilder.Seed();
        } 
    }
}