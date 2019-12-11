using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using Zad3.Implementations.Models;
using Zad3.Implementations.Services;
using Zad3.Interfaces.Models;
using Zad3.Interfaces.Services;

namespace Zad3DemoTest
{
    public class CatalogDataServiceUnitTest
    {
        private readonly Mock<ICatalogDataService> _mockCatalogDataService;
        private readonly ICatalogDataService _catalogDataService;

        public CatalogDataServiceUnitTest()
        {
            _mockCatalogDataService = new Mock<ICatalogDataService>();
            _catalogDataService = new CatalogDataService();
        }
        [Fact]
        public void CatalogDataServiceReturnItemsNotEquals()
        {
            _mockCatalogDataService.Setup(c => c.GetAllCatalogItems()).Returns(() => new List<IBaseEntity>()
            {
                new Car()
                {
                    Id = 5,
                    Name = "Test name 1",
                    Type = "NA",
                    Color = "None"
                }
            });

            Assert.NotEqual(_catalogDataService.GetAllCatalogItems(), _mockCatalogDataService.Object.GetAllCatalogItems());
        }

        [Fact]
        public void CatalogDataServiceReturnItemsContainsCarObject()
        {
            _mockCatalogDataService.Setup(c => c.GetAllCatalogItems()).Returns(() => new List<IBaseEntity>()
            {
                new Car()
                {
                    Id = 1,
                    Name = "Volkswagen",
                    Type = "Mini van",
                    Color = "Green"
                }
            });

            var mockedCar = _mockCatalogDataService.Object.GetAllCatalogItems()[0];

            var carExists = _catalogDataService.GetAllCatalogItems().Exists(i=>i.Id == mockedCar.Id);

            Assert.True(carExists);
        }
    }
}
