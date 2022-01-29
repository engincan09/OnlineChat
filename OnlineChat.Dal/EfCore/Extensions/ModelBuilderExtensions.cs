using Microsoft.EntityFrameworkCore;
using OnlineChat.Dal.EfCore.SeedData.Pages;
using OnlineChat.Dal.EfCore.SeedData.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Dal.EfCore.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region User
            RoleCreator.Create(modelBuilder);
            UserCreator.Create(modelBuilder);
            UserRoleCreator.Create(modelBuilder);
            #endregion User

            #region Systems
            PageCreator.Create(modelBuilder);
            #endregion Systems
        }
    }
}
