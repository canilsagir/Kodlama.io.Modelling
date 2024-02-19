using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.DataAccess.Abstract
{
     interface ICategoryDal
    {
        List<Category> GetAll();
        void Add(Category category);
        void Remove(Category category);
        void Update(Category category);

    }
}
