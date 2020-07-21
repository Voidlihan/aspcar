using Domain;
using Domain.Enums;
using HwProj.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HwProj.Data.Implementations
{
    public class Repository : IRepository
    {
        private readonly IList<Car> _cars;
        public Repository()
        {
            _cars = new List<Car>()
            {
                new Car
                {
                    BodyType = CarType.Coupe,
                    Brand = "Tayota",
                    Color = CarColor.White,
                    Power = 2.0
                },
                new Car
                {
                    BodyType = CarType.Crossover,
                    Brand = "BMW",
                    Color = CarColor.Black,
                    Power = 3.4
                },
                new Car
                {
                    BodyType = CarType.Sedan,
                    Brand = "Lada",
                    Color = CarColor.Gray,
                    Power = 1.6
                },
            };
        }

        public void Create(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Guid id)
        {
            _cars.Remove(_cars.FirstOrDefault(x => x.Id == id));
        }

        public void Edit(Car car)
        {
            _cars[_cars.ToList().FindIndex(x => x.Id == car.Id)] = car;
        }

        public Car Get(Guid id)
        {
            return _cars.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<Car> GetAll()
        {
            return _cars;
        }
    }
}
