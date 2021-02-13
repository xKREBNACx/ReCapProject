using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

  namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>0)
            {
                _iCarDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi");
            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");

            }
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi");
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _iCarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _iCarDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetAllByDailyPrice(decimal min, decimal max)
        {
            return _iCarDal.GetAll(c => c.DailyPrice>=min && c.DailyPrice<=max);
        }

        public Car GetById(int id)
        {
            return _iCarDal.Get(c => c.CarId == id);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _iCarDal.GetAll(c => c.ModelYear.Contains(year) == true);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _iCarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            if(car.DailyPrice>0)
            {
                _iCarDal.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi");

            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }
    }
}
