using Microsoft.EntityFrameworkCore;
using OnlineChat.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Dal.EfCore.SeedData.Users
{
    public static class UserCreator
    {
        public static readonly User SystemUser = new User
        {
            Id = 1,
            Name = "Super",
            Surname = "Admin",
            FullName = "Super Admin",
            Email = "admin@admin.com",
            Password = "9K7Cwg3Qw/8FR/S9VvrNdgl8znxhPagMZ4QrajV/3AQ=", // parola admin
            CreatedAt = new DateTime(2022, 01, 29),
            IsActive = true
        };

        public static void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[] { SystemUser });
        }
    }

}
