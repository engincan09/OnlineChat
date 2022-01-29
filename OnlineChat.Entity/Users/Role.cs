using OnlineChat.Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Entity.Users
{
    public class Role : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Role name
        /// </summary>
        public string Name { get; set; }

    }
}
