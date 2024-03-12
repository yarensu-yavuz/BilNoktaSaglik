using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //Repository=> bütün tablo classlarının crud işlemlerini kalıtım vererek yapacaktır. Tablo class'larında br dha crud işlemleri yapmaya gerek kalmayacaktır
        protected readonly BilNoktaSaglikDB _bilNoktaSaglikDB;

        public Repository(BilNoktaSaglikDB bilNoktaSaglikDB)
        {
            _bilNoktaSaglikDB = bilNoktaSaglikDB;       
        }

        public void Add(TEntity entity)
        {
          _bilNoktaSaglikDB.Add(entity);//EF ile Insert 
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
