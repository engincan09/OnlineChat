using Microsoft.EntityFrameworkCore;
using OnlineChat.Core.Entities.Concrete.Shared;
using OnlineChat.Core.Entities.Systems;
using OnlineChat.Core.Entities.Users;
using OnlineChat.Dal.EfCore.Extensions;
using OnlineChat.Entity.Rooms;
using OnlineChat.Entity.Users;
using System.Reflection;

namespace OnlineChat.Dal.EfCore
{

    public class OnlineChatContext : DbContext
    {
        public OnlineChatContext(DbContextOptions<OnlineChatContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        #region Page
        public DbSet<Page> Pages { get; set; }
        public DbSet<PagePermission> PagePermissions { get; set; }
        #endregion

        #region User
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        #endregion

        #region Room
        public DbSet<Room> Rooms { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// <summary>
            /// https://docs.microsoft.com/en-us/ef/core/modeling/indexes#indexes
            /// </summary>

            /// IndexAttribute ile oluşturulan indexleri create eder.
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
                foreach (var prop in entity.GetProperties())
                    try
                    {
                        var attr = prop.PropertyInfo.GetCustomAttribute<IndexAttribute>();
                        if (attr != null)
                        {
                            var index = entity.AddIndex(prop);
                            index.IsUnique = attr.IsUnique;
                        }
                    }
                    catch
                    {
                    }
            // Seed
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }


    }
}
