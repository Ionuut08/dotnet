using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos {get; set;}

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Todo>().HasData(
        //             new Todo { Id = 11, Description = "Burger", Created = true, IsDone = true},
        //             new Todo { Id = 12, Description = "Shaorma", Created = true, IsDone = true},
        //             new Todo { Id = 13, Description = "BurgerKing", Created = true, IsDone = true},
        //             new Todo { Id = 14, Description = "BurgerQueen", Created = true, IsDone = true},
        //             new Todo { Id = 15, Description = "BurgerMicut", Created = true, IsDone = true},
        //             new Todo { Id = 16, Description = "BurgerMaiMicut", Created = true, IsDone = true},
        //             new Todo { Id = 17, Description = "BurgerCuShaorma", Created = true, IsDone = true},
        //             new Todo { Id = 18, Description = "BurgerCuSalata", Created = true, IsDone = true},
        //             new Todo { Id = 19, Description = "ShaormaCuSalata", Created = true, IsDone = true},
        //             new Todo { Id = 20, Description = "VeganBurger", Created = true, IsDone = true}
        //         );
            
        //     modelBuilder.Seed();
        // } 
    }
}