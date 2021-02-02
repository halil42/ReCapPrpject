using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { 
                new Car{ CarId=1, CarColorId=1, CarDescription="Renault Clio", CarModelYear=2020, CarBrandId=1,  CarDailyPrice=250 },
                new Car{ CarId=2, CarColorId=2, CarDescription="Renault Clio", CarModelYear=2019, CarBrandId=1,  CarDailyPrice=220 },
                new Car{ CarId=3, CarColorId=1, CarDescription="Toyata Coralla", CarModelYear=2019, CarBrandId=2,  CarDailyPrice=300 },
                new Car{ CarId=4, CarColorId=3, CarDescription="BMW 320", CarModelYear=2018, CarBrandId=3,  CarDailyPrice=350 },
                new Car{ CarId=5, CarColorId=4, CarDescription="Volkswagen Passat", CarModelYear=2020, CarBrandId=4,  CarDailyPrice=400 }

            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);
            _car.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c=>c.Id==Id).ToList();
        }

        public void Update(Car car)
        {
           
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
        }
    }
}
