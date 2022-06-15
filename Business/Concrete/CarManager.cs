
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal carDal;
        //ctor yapıyoruz
        public CarManager(ICarDal  carDal)
        {
            this.carDal = carDal;
        }

        public void Add(Car car)
        {
            if ((car.Description.Length>= 2)&& (car.DailyPrice>0))
            {
                carDal.Add(car);
            }
            else
                Console.WriteLine("Bir sorun oluştu hatalı bilgi girildi açıklama kısmı 2 karakterden az fiyat 0 olamaz!!");
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            //Burda iş yapan kodlar var
            return carDal.GetAll();
        }

        public void update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
