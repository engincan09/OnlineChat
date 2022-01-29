using Microsoft.EntityFrameworkCore;
using OnlineChat.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Dal.EfCore.SeedData.Users
{
    public static class UserRoleCreator
    {
        public static void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>().HasData(new UserRole[] {
                    new UserRole { Id = 1,
                        UserId = 1,
                        RoleId = 1,
                         CreatedAt = new DateTime(2022, 01, 29),
                        IsActive = true
                    }
            });
        }
    }

}
