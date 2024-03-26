using BilNoktaSaglik.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _bilNoktaSaglikDB.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _bilNoktaSaglikDB.Remove(entity);
            _bilNoktaSaglikDB.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            // return _bilNoktaSaglikDB.Set<TEntity>().ToList();
            return _bilNoktaSaglikDB.Set<TEntity>().AsNoTracking().AsQueryable();
            //Tracking=> anlık kontrol için yapılır.AsNoTracking anlık kontrolleri yapma 
            //AsNoTracking=> avantajı hızdır. dezavantajı son yapılan işlemler yansımaz
            //AsQueryable()=> IQueryable<TEntity> için  List yapısı sağlar
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAllTableWithCase(Expression<Func<TEntity, bool>> predicate)
        {
            return _bilNoktaSaglikDB.Set<TEntity>().Where(predicate).ToList();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _bilNoktaSaglikDB.Set<TEntity>().Where(predicate).FirstOrDefault();
        }
    }
}
