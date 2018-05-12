using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    interface IRepository<TEntity> where TEntity : class
    {

        TEntity Get(int Id);
        //TEntity Get(Expression<Func<TEntity, bool>> where);
        ICollection<TEntity> GetAll();
        //IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where);
        int InsertorUpdate(TEntity entity);
        int Insert(TEntity entity, out int? insertedId);
        bool Delete(TEntity entity);
        //bool Delete(Expression<Func<TEntity, bool>> where);


    }
}
