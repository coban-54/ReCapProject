
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ICarService
    {
        List<Car> GetCarDetail();
        void Add(Car car);
        void Delete(Car car);
        void update(Car car);
    }
}
