using Microsoft.EntityFrameworkCore;
using OnlineChat.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Dal.EfCore.SeedData.Users
{
    public static class RoleCreator
    {
        public static void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role[] {
                    new Role {
                        Id = 1,
                        Name = "Admin",
                        CreatedAt = new DateTime(2022, 01, 29),
                        IsActive = true
                    }
            });
        }
    }

}
