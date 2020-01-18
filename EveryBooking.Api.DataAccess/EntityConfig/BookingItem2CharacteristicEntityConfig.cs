using EveryBooking.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveryBooking.Api.DataAccess.EntityConfig
{
    public class BookingItem2CharacteristicEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<BookingItem2CharacteristicEntity> entityBuilder)
        {
            entityBuilder.ToTable("BookingItem2Characteristics");
            entityBuilder.HasOne(x => x.BookingItem).WithMany(x => x.BookingItem2Characteristic).HasForeignKey(x => x.BookingItemCharacteristicId);
            entityBuilder.HasOne(x => x.BookingItemCharacteristic).WithMany(x => x.BookingItem2Characteristic).HasForeignKey(x => x.BookingItemId);
            entityBuilder.HasKey(x => new { x.BookingItemId, x.BookingItemCharacteristicId });
            entityBuilder.Property(x => x.BookingItem).IsRequired();
            entityBuilder.Property(x => x.BookingItemCharacteristic).IsRequired();
        }
    }
}
