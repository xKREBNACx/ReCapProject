using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal


    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=5000,Description="Mercedes C180"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2003,DailyPrice=8000,Description="Mercedes C200"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2001,DailyPrice=4000,Description="Wolksvagen Passat"},
                new Car{Id=4,BrandId=2,ColorId=4,ModelYear=2004,DailyPrice=7000,Description="Wolksvagen Golf"},
                new Car{Id=5,BrandId=3,ColorId=5,ModelYear=2002,DailyPrice=6000,Description="BMW 3.20"},
                new Car{Id=6,BrandId=3,ColorId=6,ModelYear=2005,DailyPrice=9000,Description="BMW 3.30"}


            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(p =>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars;
        }

        public List<Car> GetColorId(int colorId)
        {
            return _cars;
            
        }

        public List<Car> GetId(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
