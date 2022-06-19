using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class CarInMemory : ICarDal
    {
        List<Car> _cars;
        public CarInMemory()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,DailyPrice=120000,ModelYear="2010",Description="Toyota Corolla sedan otomobil"},
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=300000,ModelYear="2017",Description="Ford Focus Manitanın tercihi"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=320000,ModelYear="2019",Description="Ford Fiesta Evlilerin tercihi"},
                new Car{Id=4,BrandId=3,ColorId=5,DailyPrice=250000,ModelYear="2015",Description="Mitsubishi geniş ve rahat"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Car car)
        {
            return _cars;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
