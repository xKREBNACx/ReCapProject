using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetColorId(int colorId);
        List<Car> GetId(int id);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        
            

    }
}
