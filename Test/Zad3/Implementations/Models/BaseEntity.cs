using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad3.Interfaces.Models;

namespace Zad3.Implementations.Models
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
