using Microsoft.EntityFrameworkCore;
using OnlineChat.Entity.Systems;
using System;

namespace OnlineChat.Dal.EfCore.SeedData.Pages
{
    public static class PageCreator
    {
        public static readonly Page[] AllPages = new Page[] {
                new Page
                {
                    Id = 1,
                    ParentId = null,
                    Order = 0,
                    Name = "Yönetim Paneli",
                    AllName = "Yönetim Paneli",
                    RouterLink = "/yonetim",
                    AllRouterLink = "/yonetim",
                    MenuShow = true,
                    IsActive = true
                }
        };

        public static void Create(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().HasData(AllPages);
        }


    }
}


