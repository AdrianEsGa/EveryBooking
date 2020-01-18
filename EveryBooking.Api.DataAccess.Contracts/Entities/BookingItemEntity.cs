using System;
using System.Collections.Generic;

namespace EveryBooking.Api.DataAccess.Contracts.Entities
{
    public class BookingItemEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<BookingItem2CharacteristicEntity> BookingItem2Characteristic { get; set; }
    }
}
