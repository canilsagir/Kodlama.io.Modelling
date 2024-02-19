using Modelleme.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Entities.Concretes
{
    class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
