using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using intro.Entities;

namespace intro.Business;

    public class CourseManager
    {
        Course[]  courses = new Course[1];
        //Consturctor Metod
        public CourseManager()
        {
            Course course1 = new Course();
            course1.Id = 001;
            course1.Name = "Test";
            course1.Description = "python";

            Course course2 = new Course();
            course2.Id = 002;
            course2.Name = "Test2";
            course2.Description = "java";

            courses[0] =  course1;
            courses[1] =  course2;
        }
        public Course[] GetAll()
        {
            return courses;
        }
    }

