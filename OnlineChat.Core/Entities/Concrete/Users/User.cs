using OnlineChat.Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace OnlineChat.Core.Entities.Users
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [MaxLength(120), Required]
        public string Name { get; set; }

        /// <summary>
        /// User Surname
        /// </summary>
        [MaxLength(120), Required]
        public string Surname { get; set; }

        /// <summary>
        /// User Full Name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        [MaxLength(150),Required]
        public string Email { get; set; }

        /// <summary>
        /// User Password
        /// </summary>
        [MinLength(6), Required]
        public string Password { get; set; }

    }
}
