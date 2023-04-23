using DataAcsessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DesingPatterns.SinglePattern
{
    public class DBTool
    {
        DBTool() { }
        static TourContext _dbInstance;
        public static TourContext DbInstance
        {
            get
            {
                if (_dbInstance == null)
                    _dbInstance = new TourContext();
                return _dbInstance;
            }
        }


    }
}
