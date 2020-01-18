using EveryBooking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveryBooking.Api.DataAccess.EntityConfig
{
    public class BookingItemCharacteristicEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingItemCharacteristicEntity> entityBuilder)
        {
            entityBuilder.ToTable("BookingItemCharacteristics");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
        }


    }
}
