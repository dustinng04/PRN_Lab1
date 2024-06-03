using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BusinessObject;
namespace AutomobileLibrary.DataAccess
{

    public class CarDBContext
    {
        // Initialize car List
        private static List<Car> carList = new List<Car>()
        {
            new Car{CarId=1, CarName="CRV", Manufacturer="Honda", Price=30000, ReleaseYear=2021 },
            new Car{CarId=2, CarName="Ford Focus", Manufacturer="Ford", Price=15000, ReleaseYear=2020 }
        };

        // Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> getCarList => carList;

        public Car getCarById(int carId) { 
            Car car = carList.SingleOrDefault(c => c.CarId == carId);
            return car;
        }
        public void AddNew(Car car)
        {
            Car c = getCarById(car.CarId);
            if (c == null) carList.Add(car);
            else throw new Exception("Car is already exists");
        }

        // Update
        public void Update(Car car)
        {
            Car c = getCarById(car.CarId);
            if (c != null)
            {
                var index = carList.IndexOf(c);
                carList[index] = car;
            }
            else throw new Exception("Car is already exists");
        }
        // Remove
        public void Remove(Car car)
        {
            Car c = getCarById(car.CarId);
            if (c != null) carList.Remove(c);
            else throw new Exception("Car is already exists");
        }
    }
}