using OnlineChat.Core.Entities.Concrete;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Entity.Rooms;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Entity.Users
{
    public class UserSession : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Logged in user 
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Login time
        /// </summary>
        public DateTime SessionTime { get; set; }

        /// <summary>
        /// Room attended 
        /// </summary>
        public int? RoomId { get; set; }

        /// <summary>
        /// Information whether the user has joined the room or logged into the system 
        /// True : Room
        /// False :  Logged into the system 
        /// </summary>
        public bool IsJoinRoom  { get; set; }

        /// <summary>
        /// Room attended 
        /// </summary>
        public Room Room { get; set; }

        /// <summary>
        /// Logged in user 
        /// </summary>
        public User User { get; set; }
    }
}
