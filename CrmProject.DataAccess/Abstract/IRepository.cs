using CrmProject.Entities.Abstract;

namespace CrmProject.DataAccess.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        TEntity Add(TEntity model);
        TEntity Get(int id);
        List<TEntity> GetAll();
        void Remove(int id, TEntity model);
        void Update(TEntity model);
    }
}