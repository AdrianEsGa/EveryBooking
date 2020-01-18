using EveryBooking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace EveryBooking.Api.DataAccess.Contracts
{
    public interface IEveryBookingDbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<BookingEntity> Bookings { get; set; }
        DbSet<BookingItem2CharacteristicEntity> BookingItem2Characteristics { get; set; }
        DbSet<BookingItemCharacteristicEntity> BookingItemCharacteristics { get; set; }
        DbSet<BookingItemEntity> BookingItems { get; set; }
    }
}
