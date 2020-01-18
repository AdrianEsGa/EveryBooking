using System;

namespace EveryBooking.Api.DataAccess.Contracts.Entities
{
    public class BookingEntity
    {
        public Guid Id { get; set; }
        public virtual BookingItemEntity ReserveItem { get; set; }
        public virtual UserEntity User { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
