using EveryBooking.Api.DataAccess.Contracts;
using EveryBooking.Api.DataAccess.Contracts.Entities;
using EveryBooking.Api.DataAccess.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace EveryBooking.Api.DataAccess
{
    public class EveryBookingDbContext : DbContext, IEveryBookingDbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<BookingItem2CharacteristicEntity> BookingItem2Characteristics { get; set; }
        public DbSet<BookingItemCharacteristicEntity> BookingItemCharacteristics { get; set; }
        public DbSet<BookingItemEntity> BookingItems { get; set; }

        public EveryBookingDbContext(DbContextOptions<EveryBookingDbContext> options) : base() {}

        public EveryBookingDbContext() : base() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            BookingItem2CharacteristicEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingItem2CharacteristicEntity>());
            BookingItemCharacteristicEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingItemCharacteristicEntity>());
            BookingItemEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingItemEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());

            base.OnModelCreating(modelBuilder);
        }

    }
}
