
using System.Data.Entity;
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            var student = new Student
            {
                Name = "John Doe",
                EnrollmentDate = DateTime.Now
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    }
}
