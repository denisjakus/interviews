using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3.Interfaces.Models
{
    public interface IHouse
    {
        bool IsFlatRoof { get; set; }
        int NumberOfFloors { get; set; }
    }
}
