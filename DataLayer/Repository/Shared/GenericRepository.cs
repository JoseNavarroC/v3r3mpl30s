using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Repository.Shared;

namespace DataLayer.Repository.Shared
{
    public class GenericRepository<Entity> : BaseRepositoy, IBaseRepository<Entity> where Entity : class
    {
        protected readonly DbSet DbSet;


        public GenericRepository(prueba_verempleosEntities dbConn) 
            : base(dbConn)
        {
            DbSet = dbConn.Set<Entity>();
        }
       

        public IEnumerable<Entity> GetAll()
        {
                var query = DbSet as IQueryable<Entity>;
                if (query == null)
                {
                    return null;
                }
                return query.ToList();   
        }

        public Entity GetEntityById(Object id)
        {
            try
            {
                return (Entity)DbSet.Find(id);
            }
            catch (Exception ex) {
                return default(Entity);
            }
        }

        public void Add(Entity entity)
        {
            DbSet.Add(entity);
            DbConn.SaveChanges();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Object id)
        {
            dynamic model = DbSet.Find(id);
            DbSet.Remove(model);
        }
    }
}
