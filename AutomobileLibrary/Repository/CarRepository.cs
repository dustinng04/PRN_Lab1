using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void deleteCar(Car car)
        {
            CarDBContext.Instance.Remove(car);
        }

        public Car getCarById(int carId)
        {
            return CarDBContext.Instance.getCarById(carId);
        }

        public IEnumerable<Car> GetCars()
        {
            return CarDBContext.Instance.getCarList;
        }

        public void insertCar(Car car)
        {
            CarDBContext.Instance.AddNew(car);
        }

        public void updateCar(Car car)
        {
            CarDBContext.Instance.Update(car);
        }
    }
}
