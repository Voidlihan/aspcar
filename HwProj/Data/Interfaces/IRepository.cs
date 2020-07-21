using Domain;
using System;
using System.Collections.Generic;

namespace HwProj.Data.Interfaces
{
    public interface IRepository
    {
        void Create(Car car);
        void Edit(Car car);
        void Delete(Guid car);
        Car Get(Guid id);
        ICollection<Car> GetAll();
    }
}
