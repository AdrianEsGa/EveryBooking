using EveryBooking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveryBooking.Api.DataAccess.EntityConfig
{
    public class BookingEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingEntity> entityBuilder)
        {
            entityBuilder.ToTable("Bookings");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.HasOne(x => x.ReserveItem);
            entityBuilder.HasOne(x => x.User);
        }


    }
}
