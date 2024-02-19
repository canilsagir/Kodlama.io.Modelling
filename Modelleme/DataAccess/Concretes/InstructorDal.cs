using Modelleme.DataAccess.Abstract;
using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.DataAccess.Concretes
{
    class InstructorDal : IInstructorDal


    {
        List<Instructor> instructors;
        public InstructorDal()
        {

            Instructor teacher1 = new Instructor();
            teacher1.Id = 1;
            teacher1.FirstName = "Engin";
            teacher1.LastName = "Demiroğ";


            Instructor teacher2 = new Instructor();
            teacher2.Id = 2;
            teacher2.FirstName = "Halit Enes";
            teacher2.LastName = "Kalaycı";

            instructors = new List<Instructor>() { teacher1, teacher2 };



        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Remove(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor updatedInstructor = instructors.SingleOrDefault(i => i.Id == instructor.Id);
            instructor.FirstName = updatedInstructor.FirstName;
            instructor.LastName = updatedInstructor.LastName;
        }
    }
}
