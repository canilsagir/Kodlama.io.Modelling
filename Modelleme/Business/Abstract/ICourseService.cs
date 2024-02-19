using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Business.Abstract
{
     interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
    }
}
