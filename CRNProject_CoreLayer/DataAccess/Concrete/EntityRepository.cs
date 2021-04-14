using CRNProject_CoreLayer.DataAccess.Abstract;
using CRNProject_CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_CoreLayer.DataAccess.Concrete
{
    public class EntityRepository<Context, T> : IEntityRepository<T>
        where T : class, IEntity, new()
        where Context : DbContext
    {
        private Context context { get; set; }

        public EntityRepository(Context _context)
        {
            context = _context;
        }
        public async Task<bool> Add(T entity)
        {
            try
            {
                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                string mesaj = ex.Message;
                return false;
            }
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null)
        {
            return expression == null ? await context.Set<T>().ToListAsync() : await context.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<bool> SaveChanges()
        {
            int result = await context.SaveChangesAsync();
            return result > 0 ? true : false;
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                string mesaj = ex.Message;
                return false;
            }
        }
    }
}
