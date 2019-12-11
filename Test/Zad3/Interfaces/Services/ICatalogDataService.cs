using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3.Interfaces.Models;

namespace Zad3.Interfaces.Services
{
    public interface ICatalogDataService
    {
        List<IBaseEntity> GetAllCatalogItems();
    }
}
