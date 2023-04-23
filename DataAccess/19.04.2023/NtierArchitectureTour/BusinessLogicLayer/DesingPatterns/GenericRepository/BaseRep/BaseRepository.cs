using BusinessLogicLayer.DesingPatterns.GenericRepository.IntRep;
using BusinessLogicLayer.DesingPatterns.SinglePattern;
using DataAcsessLayer.Context;
using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DesingPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseClass
    {
        TourContext _db;
        public BaseRepository() 
        {
            _db = DBTool.DbInstance;
        }

        void Save()
        {
            _db.SaveChanges();//datetime yüzünden hata veriyorrr!!!
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
            Save();
        }

        public void Delete(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
            
        }

        public List<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetDeleteds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            item.Status = DataAcsessLayer.Enum.DataStatus.Updated;
            item.ModifiedDate =DateTime.Now;
            T unchangedEntity = Find(item.Id);
            _db.Entry(unchangedEntity).CurrentValues.SetValues(item);
            Save();

        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list)
            {
                Update(item);
            }
        }
    }
}

