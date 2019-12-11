using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3.Interfaces.Models;

namespace Zad3.Implementations.Models
{
    public class Person : BaseEntity, IPerson
    {
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
