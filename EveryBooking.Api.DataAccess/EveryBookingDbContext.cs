using EveryBooking.Api.DataAccess.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EveryBooking.Api.DataAccess
{
    public class EveryBookingDbContext : DbContext, IEveryBookingDbContext
    {
        public EveryBookingDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
