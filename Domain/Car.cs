using Domain.Enums;
using System;

namespace Domain
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public CarColor Color { get; set; }
        public CarType BodyType { get; set; }
        public double Power { get; set; }
    }
}
