using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3.Interfaces.Models;

namespace Zad3.Implementations.Models
{
    public class House : BaseEntity, IHouse
    {
        public bool IsFlatRoof { get; set; }
        public int NumberOfFloors { get; set; }
    }
}
