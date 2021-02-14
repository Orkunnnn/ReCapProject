﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailsDto> GetCarDetails(); 
        Car GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
