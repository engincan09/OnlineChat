using OnlineChat.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineChat.Entity.Systems
{
    /// <summary>
    /// It is the area where all pages in the system are kept.
    /// </summary>
    public class Page : BaseEntity
    {
        /// <summary>
        /// Table primary key id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Parent page is singular information
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Page ranking information.
        /// </summary>
        public short Order { get; set; }

        /// <summary>
        /// Page name
        /// </summary>
        [Required, MaxLength(75)]
        public string Name { get; set; }

        /// <summary>
        /// Page description
        /// </summary>
        [MaxLength(250)]
        public string Description { get; set; }

        /// <summary>
        /// It is the area where the page is held together with all its headers.
        /// </summary>
        [MaxLength(250)]
        public string AllName { get; set; }

        /// <summary>
        /// It is the referrer link information of the page.
        /// </summary>
        [MaxLength(100)]
        public string RouterLink { get; set; }

        /// <summary>
        /// It is the whole of the links created by combining the top page information of the page.
        /// </summary>
        [MaxLength(250)]
        public string AllRouterLink { get; set; }

        /// <summary>
        /// It is the area where the icon information of the page is kept.
        /// </summary>
        [MaxLength(50)]
        public string Icon { get; set; }

        /// <summary>
        /// It is the information of whether the page appears in the menu or not.
        /// </summary>
        public bool MenuShow { get; set; }

        /// <summary>
        /// Parent page is singular information.
        /// </summary>
        public Page Parent { get; set; }

        /// <summary>
        /// Returns all subpage information.
        /// </summary>
        public ICollection<Page> Childs { get; set; }

        /// <summary>
        /// The page returns all privileges.
        /// </summary>
        public ICollection<PagePermission> PagePermission { get; set; }
    }

}
