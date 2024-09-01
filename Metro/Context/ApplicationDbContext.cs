using Metro.Models;
using Microsoft.EntityFrameworkCore;

namespace Metro.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Line1Station> Line1Stations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\DELL\Desktop\Metro\Metro\DbFile\metro.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Line1Station>().HasData(
                new Line1Station { Id = 1, StationName = "Helwan" },
                new Line1Station { Id = 2, StationName = "Ain Helwan" },
                new Line1Station { Id = 3, StationName = "Helwan University" },
                new Line1Station { Id = 4, StationName = "Wadi Hof" },
                new Line1Station { Id = 5, StationName = "Hadayek Helwan" },
                new Line1Station { Id = 6, StationName = "El Maasara" },
                new Line1Station { Id = 7, StationName = "Tora El Asmant" },
                new Line1Station { Id = 8, StationName = "Kozzika" },
                new Line1Station { Id = 9, StationName = "Tora El Balad" },
                new Line1Station { Id = 10, StationName = "Sakanat El Maadi" },
                new Line1Station { Id = 11, StationName = "Maadi" },
                new Line1Station { Id = 12, StationName = "Hadayek El Maadi" },
                new Line1Station { Id = 13, StationName = "Dar El Salam" },
                new Line1Station { Id = 14, StationName = "El Zahraa" },
                new Line1Station { Id = 15, StationName = "Mar Girgis" },
                new Line1Station { Id = 16, StationName = "El Malek El Saleh" },
                new Line1Station { Id = 17, StationName = "Al Sayeda Zeinab" },
                new Line1Station { Id = 18, StationName = "Saad Zaghloul" },
                new Line1Station { Id = 19, StationName = "Sadat" },
                new Line1Station { Id = 20, StationName = "Nasser" },
                new Line1Station { Id = 21, StationName = "Orabi" },
                new Line1Station { Id = 22, StationName = "Al Shohadaa" },
                new Line1Station { Id = 23, StationName = "Ghamra" },
                new Line1Station { Id = 24, StationName = "El Demerdash" },
                new Line1Station { Id = 25, StationName = "Manshiet El Sadr" },
                new Line1Station { Id = 26, StationName = "Kobri El Qobba" },
                new Line1Station { Id = 27, StationName = "Hammamat El Qobba" },
                new Line1Station { Id = 28, StationName = "Saray El Qobba" },
                new Line1Station { Id = 29, StationName = "Hadayeq El Zaitoun" },
                new Line1Station { Id = 30, StationName = "Helmeyet El Zaitoun" },
                new Line1Station { Id = 31, StationName = "El Matareyya" },
                new Line1Station { Id = 32, StationName = "Ain Shams" },
                new Line1Station { Id = 33, StationName = "Ezbet El Nakhl" },
                new Line1Station { Id = 34, StationName = "El Marg" },
                new Line1Station { Id = 35, StationName = "New El Marg" }
            );
        }

    }
}
