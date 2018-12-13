using Planner.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planner.Core;
using System.Linq.Expressions;
using Planner.Data;
using System.Linq.Dynamic;
using System.Data.Entity;

namespace Planner.Service
{
    /// <summary>
    /// Service class used for CRUD operations
    /// </summary>
    /// <typeparam name="TEntity">Type</typeparam>
    public class CrudService<TEntity> : IService<TEntity> where TEntity : class, IEntity
    {
        private UnitOfWork<TEntity> _unitOfWork;

        public CrudService()
        {
            _unitOfWork = new UnitOfWork<TEntity>();
        }

        protected UnitOfWork<TEntity> UnitOfWork
        {
            get
            {
                return _unitOfWork;
            }
        }

        public virtual void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _unitOfWork.Repository.Insert(entity);

        }

        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _unitOfWork.Repository.Delete(entity);
        }

        public virtual IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            List<TEntity> list;

            var dbQuery = _unitOfWork.Repository.TableNoTracking;

            foreach (Expression<Func<TEntity, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<TEntity, object>(navigationProperty);

            list = dbQuery
                   .ToList<TEntity>();

            return list;
        }

        public virtual IList<TEntity> GetList(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            List<TEntity> list;

            var dbQuery = _unitOfWork.Repository.TableNoTracking;

            foreach (Expression<Func<TEntity, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<TEntity, object>(navigationProperty);

            list = dbQuery
                   .Where(where)
                   .ToList<TEntity>();

            return list;
        }

        public virtual IPagedList<TEntity> GetPagedList(PagingParameter pagingOptions, Expression<Func<TEntity, bool>> predicate)
        {
            var query = _unitOfWork.Repository.TableNoTracking;

            if (!string.IsNullOrEmpty(pagingOptions.GlobalSearchText))
            {
                query = query.Where(predicate);
            }

            if (!string.IsNullOrEmpty(pagingOptions.SortColumn))
            {
                query = query.OrderBy(pagingOptions.SortColumn + " " + pagingOptions.SortOrder);
            }
            
            var pagedList = new PagedList<TEntity>(query, pagingOptions.PageIndex, pagingOptions.PageSize);
            return pagedList;
        }

        public virtual TEntity GetSingle(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            TEntity item = null;

            var dbQuery = _unitOfWork.Repository.Table;

            foreach (Expression<Func<TEntity, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<TEntity, object>(navigationProperty);

            item = dbQuery.FirstOrDefault(where);

            return item;
        }

        public virtual TEntity GetSingleById(int id)
        {
            TEntity item = null;

            var dbQuery = _unitOfWork.Repository.Table;

            item = dbQuery
                    .FirstOrDefault(a => a.Id == id);

            return item;
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _unitOfWork.Repository.Update(entity);
        }
    }
}
