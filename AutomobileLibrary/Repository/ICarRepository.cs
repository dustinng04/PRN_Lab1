using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car getCarById(int carId);
        void insertCar(Car car);
        void deleteCar(Car car);
        void updateCar(Car car);
    }
}
