using Modelleme.DataAccess.Abstract;
using Modelleme.Entities;
using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.DataAccess.Concretes
{
    internal class CategoryDal : ICategoryDal
    {   
        List<Category> _categories;
        public CategoryDal() {

            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Programlama";


            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Algoritma";

            _categories = new List<Category>() { category1, category2 };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Remove(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            Category updateCategory=_categories.SingleOrDefault(category => category.Id == category.Id);
            category.Name = updateCategory.Name;
        }
    }
}
