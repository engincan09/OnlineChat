using OnlineChat.Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Entity.Rooms
{
    public class Room : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Room name
        /// </summary>
        [MaxLength(512),Required]
        public string Name { get; set; }

        /// <summary>
        /// Room Description
        /// </summary>
        [MaxLength(512)]
        public string Description { get; set; }
    }
}
