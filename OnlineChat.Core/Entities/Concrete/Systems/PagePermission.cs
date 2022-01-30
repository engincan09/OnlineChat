using OnlineChat.Core.Entities.Concrete;
using OnlineChat.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineChat.Core.Entities.Systems
{
    /// <summary>
    /// It is the table where all listing and access rights of the pages are kept.
    /// </summary>
    public class PagePermission : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The person who has access to the page is the unique information.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// It is the user role singular information that has access to the page.
        /// </summary>
        public int? RoleId { get; set; }

        /// <summary>
        /// The page is singular information.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Access to the page is prohibited?
        /// </summary>
        public bool Forbidden { get; set; }

        /// <summary>
        ///  The person who has access to the page is the unique information.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// It is the user role singular information that has access to the page.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// The page is singular information.
        /// </summary>
        public Page Page { get; set; }
    }

}
