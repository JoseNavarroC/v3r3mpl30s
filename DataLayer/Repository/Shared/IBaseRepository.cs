using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Shared
{
    public interface IBaseRepository<Entity>
    {
        IEnumerable<Entity> GetAll();
        Entity GetEntityById(Object id);
        void Add(Entity entity);
        void Delete(Object id);
        void Update(Entity entity);
    }
}
