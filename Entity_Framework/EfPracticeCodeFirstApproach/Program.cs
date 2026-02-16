using System;
using EfPracticeCodeFirstApproach.Model;
using EfPracticeCodeFirstApproach.Model.Context;

namespace EfPracticeCodeFirstApproach
{
    public class Program
    {
        public static void Main()
        {
            //Insert
            // using (var context = new SchoolContext())
            // {
            //     Student student = new Student
            //     {
            //         Name = "Nilesh",
            //         Email = "Nilesh@yahoo.com",
            //         BranchId = 103,
            //         Phone = "1234567459"
            //     };
            //     context.Students.Add(student);
            //     context.SaveChanges();
            //     Console.WriteLine("Student added Successfully.");
            // }

            //Retrieve
            using (var context = new SchoolContext())
            {
                var v = context.Students.ToList();
                foreach (var k in v)
                {
                    Console.WriteLine($"Id: {k.Id}     Name: {k.Name}     Email: {k.Email}     BranchId: {k.BranchId}   Phone: {k.Phone}");

                }
            }

            //get student by id
            using (var context = new SchoolContext())
            {
                var studentsWithSameName = context.Students
                                                  .Where(s => s.Id == 4)
                                                  .ToList();
                foreach (var item in studentsWithSameName)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Email);
                    Console.WriteLine(item.BranchId);
                    Console.WriteLine(item.Phone);
                }
            }
            //Update
            using (SchoolContext context = new SchoolContext())
            {
                var std = context.Students.Find(4);
                std.Name = "kravi";
                std.Email = "kravik2007@gmail.com";
                std.BranchId = 105;
                context.SaveChanges();
                Console.WriteLine("Record Update Successfully");
            }

            using (var context = new SchoolContext())
            {
                var std = context.Students.Find(4);
                context.Students.Remove(std);

                //or
                //context.Remove<Student>(std);

                context.SaveChanges();
                Console.WriteLine("Record Deleted Successfully");
            }


        }
    }
}
