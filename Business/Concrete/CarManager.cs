
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
        public List<Car> GetAll()
        {
            //Burda iş yapan kodlar var
            return carDal.GetAll();
        }
    }
}
