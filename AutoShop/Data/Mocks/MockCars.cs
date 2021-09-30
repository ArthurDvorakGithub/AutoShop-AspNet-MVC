using AutoShop.Data.Interfaces;
using AutoShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>
                {
                    new Car 
                    {
                        name = "Tesla", 
                        shortDesc = "Быстрый и надежный", 
                        longDesc = "Создал сам Илон Маск", 
                        img = "img", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiest",
                        shortDesc = "Маленький и резвый",
                        longDesc = "Удобный авто для города",
                        img = "img",
                        price = 9000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M5",
                        shortDesc = "Супер стильный авто",
                        longDesc = "Сделано в Германии",
                        img = "img",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "VW Amarok",
                        shortDesc = "Супер большой авто",
                        longDesc = "Для занятых людей",
                        img = "img",
                        price = 59000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный авто для города",
                        img = "img",
                        price = 33000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                };
            } 
                
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
