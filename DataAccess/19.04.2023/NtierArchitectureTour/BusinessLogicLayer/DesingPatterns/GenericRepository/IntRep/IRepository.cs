using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DesingPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseClass
    {
        //Listeleme
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetModifieds();
        List<T> GetDeleteds();

        //Ekleme
        void Add(T item);
        void AddRange(List<T> list);

        //Silme
        void Delete(T item);
        void DeleteRange(List<T> list);

        //Güncelleme
        void Update(T item);
        void UpdateRange(List<T> list);

        //Find
        T Find(int id);

        



    }
}
