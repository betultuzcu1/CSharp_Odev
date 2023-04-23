using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Options
{
    public abstract class BaseMap<T>: EntityTypeConfiguration<T> where T : BaseClass
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).HasColumnName("Oluşturulma Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Güncelleme Tarihi");
            Property(x => x.DeletedDate).HasColumnName("Silme Tarihi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
