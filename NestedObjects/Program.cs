using System;

namespace NestedObjects
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Course cpw212 = new Course()
            {
                CourseID = 1,
                Title = "Advanced .NET",
                Credits = 5,
                Description = "Advanced C#"
            };
        }
    }
}
