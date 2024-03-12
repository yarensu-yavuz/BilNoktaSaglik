using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepository
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

        void Add(T entity);


    }
}
