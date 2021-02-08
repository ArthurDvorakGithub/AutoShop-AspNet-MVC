using AutoShop.Data.Interfaces;
using AutoShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Экологичный вид транспорта" },
                    new Category {categoryName = "Классические автомобили", desc ="Машины с ДВС" }
                };
            }
        }
    }
}
