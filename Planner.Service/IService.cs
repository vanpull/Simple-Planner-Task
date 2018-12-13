using Planner.Core;
using Planner.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Service
{
    public interface IService<TEntity> where TEntity : class, IEntity
    {
        IPagedList<TEntity> GetPagedList(PagingParameter pagingOptions, Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties);
        IList<TEntity> GetList(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties);
        TEntity GetSingleById(int id);
        TEntity GetSingle(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
