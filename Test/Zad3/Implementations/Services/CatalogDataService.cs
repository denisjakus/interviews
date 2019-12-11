using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3.Implementations.Models;
using Zad3.Interfaces.Models;
using Zad3.Interfaces.Services;

namespace Zad3.Implementations.Services
{
    public class CatalogDataService : ICatalogDataService
    {
        private readonly List<IBaseEntity> _catalogItems;

        public CatalogDataService()
        {
            _catalogItems = new List<IBaseEntity>()
            {
                new Car()
                {
                    Id = 1,
                    Name = "Volkswagen",
                    Type = "Mini van",
                    Color = "Green"
                },
                new House()
                {
                    Id = 2,
                    Name = "Twin Peaks",
                    IsFlatRoof = true,
                    NumberOfFloors = 2
                },
                new Person()
                {
                    Id = 3,
                    Name = "Jesse James",
                    Age = 20,
                    Address = "Wild west boulevard 3"
                }
            };
        }

        public List<IBaseEntity> GetAllCatalogItems()
        {
            return _catalogItems;
        }
    }
}
