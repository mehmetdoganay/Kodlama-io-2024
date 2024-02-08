using intro.Business;
using intro.Entities;



for (int i = 0; i < courses1.lenght; i++)
{
    Console.WriteLine(courses2[i].Name);
}
    
CourseManager  courseManager = new CourseManager();
Course[] courses1 = courseManager.GetAll();