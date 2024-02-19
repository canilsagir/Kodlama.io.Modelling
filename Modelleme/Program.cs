// See https://aka.ms/new-console-template for more information
using Modelleme.Business.Concretes;
using Modelleme.DataAccess.Abstract;
using Modelleme.DataAccess.Concretes;
using Modelleme.Entities.Concretes;
using System.Runtime.CompilerServices;

CourseTest();
CategoryTest();
InstructorTest();

static void CourseTest()
{
    CourseManager courseManager = new(new CourseDal());
    List<Course> courses = courseManager.GetAll();
    for (int i = 0; i < courses.Count; i++)
    {
        Console.WriteLine(courses[i].Name + " / " + courses[i].Description);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new CategoryDal());
    var result = categoryManager.GetAll();
    foreach (var c in result)
    { Console.WriteLine("Kategoriler :"+" "+c.Name);}
    

}

static void InstructorTest()
{
    InstructorManager instructorManager = new(new InstructorDal());
    var result = instructorManager.GetAll();
    foreach(var instructor in result)
    {
        Console.WriteLine("Eğitmenler :" + instructor.FirstName+ " "+instructor.LastName);
    }

}