using EveryBooking.Api.DataAccess.Contracts.Enum;
using System;

namespace EveryBooking.Api.DataAccess.Contracts.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public UserRoles Rol { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
