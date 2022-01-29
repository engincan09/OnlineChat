using OnlineChat.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineChat.Entity.Users
{
    public class UserRole : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// RoleId
        /// </summary>
        public int RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}
