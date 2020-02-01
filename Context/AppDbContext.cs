using System;
using Booking1.Domain.Model;
using Microsoft.EntityFrameworkCore;


namespace Booking1.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Salon> Salon { get; set; }
        public DbSet<Show> Show { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Salon>().ToTable("salon");
            builder.Entity<Salon>().HasKey(p => p.Id);
            builder.Entity<Salon>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Salon>().Property(p => p.Name).IsRequired().HasMaxLength(256);
            builder.Entity<Salon>().Property(p => p.SeatWidth).IsRequired();
            builder.Entity<Salon>().Property(p => p.SeatHeight).IsRequired();


            builder.Entity<Salon>().HasData
            (
                new Salon("sina salon", 100, 10, 11),
                new Salon("hadi salon", 102, 10, 13)
            );

            builder.Entity<Show>().ToTable("show");
            builder.Entity<Show>().HasKey(p => p.Id);
            builder.Entity<Show>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Show>().Property(p => p.StartTime).IsRequired();
            builder.Entity<Show>().Property(p => p.EndTime).IsRequired();
            builder.Entity<Show>().Property(p => p.Title).IsRequired().HasMaxLength(256);
            builder.Entity<Show>().Property(p => p.Summary).HasMaxLength(2000);
            builder.Entity<Show>().Property(p => p.Price).IsRequired();
            builder.Entity<Show>().HasOne<Salon>(p => p.Salon).WithMany
                (p => p.Shows).HasForeignKey(p => p.SalonId);


            builder.Entity<Show>().HasData
            (
                new Show("Bojack", new DateTime(2020, 1, 25, 20, 30, 50)
                    , new DateTime(2020, 1, 25, 21, 30, 50), null, 14, 201, 100),
                new Show("Rick and Morty", new DateTime(2020, 1, 26, 20, 30, 50)
                    , new DateTime(2020, 1, 26, 21, 30, 50), "let's get schwifty", 20, 202, 102)
            );

            builder.Entity<Seat>().ToTable("seat");
            builder.Entity<Seat>().HasKey(p => p.Id);
            builder.Entity<Seat>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Seat>().Property(p => p.X).IsRequired();
            builder.Entity<Seat>().Property(p => p.Y).IsRequired();
            builder.Entity<Seat>().Property(p => p.SalonId).IsRequired();
            
            builder.Entity<Seat>().HasOne(s => s.Salon).WithMany
                (s => s.Seats).HasForeignKey(s => s.SalonId);
            builder.Entity<Seat>().HasData(
                new Seat(301, 100, 10, 11),
                new Seat(302, 102, 10, 11)
            );

            builder.Entity<Ticket>().ToTable("ticket");
            builder.Entity<Ticket>().Property(p => p.Show).IsRequired();
            builder.Entity<Ticket>().Property(p => p.Seat).IsRequired();
            builder.Entity<Ticket>().Property(p => p.SeatId).IsRequired();
            builder.Entity<Ticket>().Property(p => p.ShowId).IsRequired();
            builder.Entity<Ticket>().Property(p => p.UserId).IsRequired();
            builder.Entity<Ticket>().HasOne(s => s.Seat).WithMany
                (s => s.Tickets).HasForeignKey(s => s.SeatId);
            builder.Entity<Ticket>().Property(p => p.Show).IsRequired();

            builder.Entity<Ticket>().HasData(
                new Ticket(10, 201, 301),
                new Ticket(11, 202, 302)
            );
        }
    }
}