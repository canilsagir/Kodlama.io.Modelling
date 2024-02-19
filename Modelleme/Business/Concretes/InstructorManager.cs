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
    class InstructorManager : IInstructorService

    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
           return _instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}
