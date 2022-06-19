
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
        ICarDal _carDal;
        //ctor yapıyoruz
        public CarManager(ICarDal  carDal)
        {
            this._carDal = carDal;
        }

        public void Add(Car car)
        {
            if ((car.Description.Length>= 2)&& (car.DailyPrice>0))
            {
                _carDal.Add(car);
            }
            else
                Console.WriteLine("Bir sorun oluştu hatalı bilgi girildi açıklama kısmı 2 karakterden az fiyat 0 olamaz!!");
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarDetail()
        {
            //Burda iş yapan kodlar var
            return _carDal.GetAll();
        }

        public void update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
