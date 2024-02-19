using Modelleme.DataAccess.Abstract;
using Modelleme.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.DataAccess.Concretes;

class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "Senior Yazılım Geliştirici Yetiştirme Kampı";
            course1.Description = ".NET";

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Yazılım Geliştirici Yetiştirme Kampı";
            course2.Description = "C#+ANGULAR";

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "(2023)Yazılım Geliştirici Yetiştirme Kampı";
            course3.Description = "Pyhthon & Selenium";

            Course course4 = new Course();
            course4.Id = 4;
            course4.Name = "(2022)Yazılım Geliştirici Yetiştirme Kampı";
            course4.Description = "JAVA";

            Course course5 = new Course();
            course5.Id = 5;
            course5.Name = "Yazılım Geliştirici Yetiştirme Kampı";
            course5.Description = "JAVASCRIPT";

            Course course6 = new Course();
            course6.Id = 6;
            course6.Name = "Yazılım Geliştirici Yetiştirme Kampı";
            course6.Description = "JAVA + REACT";

            Course course7 = new Course();
            course7.Id = 7;
            course7.Name = "(2024)Yazılım Geliştirici Yetiştirme Kampı";
            course7.Description = "C#";

            Course course8 = new Course();
            course8.Id = 8;
            course8.Name = "Proglammaya Giriş için Temel Kurs";


            courses = new List<Course>() { course1, course2, course3, course4, course5, course6, course7, course8, course8 };
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public void Update(Course course)
        {
           
        }
    }

