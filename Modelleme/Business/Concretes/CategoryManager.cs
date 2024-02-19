using Modelleme.Business.Abstact;
using Modelleme.DataAccess.Abstract;
using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Business.Concretes
{
    class CategoryManager : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

       

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }


        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        
    }
}
