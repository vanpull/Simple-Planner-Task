using Planner.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data
{
    /// <summary>
    /// Represents Unit of Work for accessing Business logic service
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class UnitOfWork<TEntity> where TEntity : class, IEntity
    {
        private readonly PlannerContext _context;

        private BaseRepository<TEntity> _repository;

        public UnitOfWork()
        {
            _context = new PlannerContext();
        }

        public BaseRepository<TEntity> Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new BaseRepository<TEntity>(_context);
                }
                return _repository;
            }
        }
    }
}
