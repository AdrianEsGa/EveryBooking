
using System;

namespace EveryBooking.Api.DataAccess.Contracts.Entities
{
    public class BookingItem2CharacteristicEntity
    {
        public Guid BookingItemId { get; set; }
        public Guid BookingItemCharacteristicId { get; set; }

        public virtual BookingItemEntity BookingItem { get; set; }
        public virtual BookingItemCharacteristicEntity BookingItemCharacteristic { get; set; }
    }
}
