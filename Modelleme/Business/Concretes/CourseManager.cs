using Modelleme.Business.Abstract;
using Modelleme.DataAccess.Abstract;
using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Business.Concretes;

class CourseManager :ICourseService

{
    //Dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;

    }

    public List<Course> GetAll()
    {

        return _courseDal.GetAll();

        Console.WriteLine("Mevcut Kurslar Listelendi.");
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }
    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }



}
