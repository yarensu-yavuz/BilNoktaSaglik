using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // IRepository<TEntity> where TEntity : class
        /*
         IRepository<TEntity> ??=>
         where TEntity : class ??=>
         
         
         
         */
        //TEntity=> varsayılan bir table adı olacak
        //Crud=> table
        //Rules,Users, products,Categoris

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllTableWithCase(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(Expression<Func<TEntity, bool>> predicate);
    }

}
