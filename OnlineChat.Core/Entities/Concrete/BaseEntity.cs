using OnlineChat.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineChat.Core.Entities.Concrete
{
    public class BaseEntity : IEntity
    {

        /// <summary>
        /// Data creation date 
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data update date 
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Created by user 
        /// </summary>
        public int? CreatedUserId { get; set; }

        /// <summary>
        /// Data deletion status 
        /// </summary>
        public bool IsActive { get; set; }
    }
}
