using EveryBooking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveryBooking.Api.DataAccess.EntityConfig
{
    public class BookingItemEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingItemEntity> entityBuilder)
        {
            entityBuilder.ToTable("BookingItems");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
            entityBuilder.HasMany(x => x.BookingItem2Characteristic);
        }


    }
}
