using Microsoft.EntityFrameworkCore;
using Production.Contracts;
using Production.Entities.AdventureContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Production.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AdventureContext adventureContext;
        //protected AdventureWorks2019Context adventure;

        public RepositoryBase(AdventureContext adventure)
        {
            //this.adventure = adventure;
            adventureContext = adventure;
        }

        public void Create(T entity) => adventureContext.Set<T>().Add(entity);
        public void Delete(T entity) => adventureContext.Set<T>().Add(entity);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? adventureContext.Set<T>().AsNoTracking() : adventureContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? adventureContext.Set<T>().AsNoTracking()
            : adventureContext.Set<T>().Where(expression);

        public void Update(T entity) => adventureContext.Set<T>().Update(entity);

    }
}
