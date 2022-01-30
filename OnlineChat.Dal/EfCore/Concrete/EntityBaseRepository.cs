using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineChat.Core.Entities.Abstract;
using OnlineChat.Core.Entities.Concrete;
using OnlineChat.Dal.EfCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineChat.Dal.EfCore.Concrete
{
    public class EntityBaseRepository<TEntity> : HttpContextAccessor, IEntityBaseRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private OnlineChatContext _context;
        public EntityBaseRepository(OnlineChatContext context)
        {
            _context = context;
        }


        public void Add(TEntity entity)
        {

            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            BeforeSaving();
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {

            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            BeforeSaving();
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            BeforeSaving();
            _context.SaveChanges();

        }

        private void BeforeSaving()
        {
            if (HttpContext != null)
            {
                DateTime now = DateTime.Now;
                int.TryParse(HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "userId")?.Value, out int id);
                int? userId = (id == 0 ? (int?)null : id);


                foreach (var item in _context.ChangeTracker.Entries().Where(e => e.Entity is BaseEntity))
                {
                    switch (item.State)
                    {
                        case EntityState.Detached:
                            ((BaseEntity)item.Entity).CreatedAt = now;
                            ((BaseEntity)item.Entity).CreatedUserId = userId;
                            ((BaseEntity)item.Entity).IsActive = true;
                            break;
                        case EntityState.Unchanged:
                            break;
                        case EntityState.Deleted:
                            ((BaseEntity)item.Entity).IsActive = false;
                            break;
                        case EntityState.Modified:
                            ((BaseEntity)item.Entity).UpdateTime = now;
                            break;
                        case EntityState.Added:
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
