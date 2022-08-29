using CrmProject.DataAccess.Context;
using CrmProject.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CrmProject.DataAccess.Abstract
{

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : EntityBase

    {
        private readonly DatabaseContext _context;
        private readonly DbSet<TEntity> _set;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }
        //insert customer data
        public List<TEntity> GetAll()
        {
            return _set.ToList();
        }
        public TEntity Get(int id)
        {
            return _set.Find(id);
        }
        public TEntity Add(TEntity model)
        {
            _set.Add(model);
            if (_context.SaveChanges() > 0)

                return model;


            return null;
        }
        public void Update(TEntity model)
        {
            if (model.Id == 0)
            {
                throw new ArgumentNullException(nameof(model.Id));
            }
            var entity = _context.Entry(model);
            entity.State = EntityState.Modified;
            if (_context.SaveChanges() == 0)
                throw new Exception("Failed to edit");
        }
        public void Remove(int id, TEntity model)
        {
            _set.Remove(Get(id));
            if (_context.SaveChanges() == 0)
                throw new Exception("Failed to delete");
        }

    }
}