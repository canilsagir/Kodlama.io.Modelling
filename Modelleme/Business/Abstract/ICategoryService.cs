using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Business.Abstact
{
     interface ICategoryService
    {
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);
        List<Category> GetAll();
    }
}
