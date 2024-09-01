using EFCore_Assignment.Context;
using EFCore_Assignment.Entities;

namespace EFCore_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region CRUD Operations

            #region Instructors
            #region Insert

            //Instructor Ins01 = new Instructor() { Name = "Ahmed", Bonus = 10, Salary = 5_000, HoureRate = 10};
            //Instructor Ins02 = new Instructor() { Name = "Mohamed", Bonus = 20, Address = "Dokki",Salary = 10_000, HoureRate = 12};
            //Console.WriteLine(dbContext.Entry(Ins01).State); // Detached

            //dbContext.Add(Ins01);
            //dbContext.Add(Ins02);

            //Console.WriteLine(dbContext.Entry(Ins01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Ins01).State); // UnChanged

            #endregion

            #region Select

            ////var Instructors = dbContext.Instructors;

            ////foreach(var instructor in Instructors)
            ////    Console.WriteLine(instructor.Name);

            //var instructor = (from Ins in dbContext.Instructors
            //                 where Ins.Id == 2
            //                 select Ins).FirstOrDefault();

            //// Console.WriteLine(instructor?.Name ?? "NA");

            #endregion

            #region Update

            //Console.WriteLine(dbContext.Entry(instructor).State); // Unchanged

            //instructor.Name = "Ahmed Nasr";

            //Console.WriteLine(dbContext.Entry(instructor).State); // Modified


            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(instructor).State); // Unchanged


            #endregion

            #region Delete

            //Console.WriteLine(dbContext.Entry(instructor).State); // Unchanged

            //dbContext.Remove(instructor);

            //Console.WriteLine(dbContext.Entry(instructor).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(instructor).State); // Detached

            #endregion
            #endregion

            #region Department

            #region Insert
            //Department D01 = new Department() { Name = "D01", HirirngDate = DateTime.Now };
            //Department D02 = new Department() { Name = "D02", HirirngDate = DateTime.Now };

            //Console.WriteLine(dbContext.Entry(D01).State); // Detached

            //dbContext.Set<Department>().Add(D01);
            //dbContext.Set<Department>().Add(D02);

            //Console.WriteLine(dbContext.Entry(D01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(D01).State); // Unchanged
            #endregion

            #region Select

            //var department = (from D in dbContext.Set<Department>()
            //                  where D.Id == 20
            //                  select D).FirstOrDefault();
            //// Console.WriteLine(department?.Name ?? "NA");
            #endregion

            #region Update

            //department.Name = "Test";
            //dbContext.SaveChanges();

            #endregion

            #region Delete

            //dbContext.Remove(department);
            //dbContext.SaveChanges();
            #endregion

            #endregion

            #region Students
            #region Insert
            //Student S01 = new Student() { FName = "Doaa", LName = "Elfawal", Age = 24, Address = "New Cairo" };
            //Student S02 = new Student() { FName = "Mohamed", LName = "Gamal", Age = 27, Address = "Nasr City" };

            //Console.WriteLine(dbContext.Entry(S01).State); // Detached

            //dbContext.Students.Add(S01);
            //dbContext.Students.Add(S02);

            //Console.WriteLine(dbContext.Entry(S01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(S01).State); // Unchanged 
            #endregion

            #region Select
            //var student = (from S in dbContext.Students
            //               where S.Id == 2
            //               select S).FirstOrDefault();

            //Console.WriteLine(student?.FName ?? "NA"); 
            #endregion

            #region Update
            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged

            //student.FName = "Dina";

            //Console.WriteLine(dbContext.Entry(student).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged 
            #endregion

            #region Delete
            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged

            //dbContext.Remove(student);

            //Console.WriteLine(dbContext.Entry(student).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(student).State); // Detached 
            #endregion
            #endregion

            #region Topic
            #region Insert
            //Topic T01 = new Topic() { Name = "Binding" };
            //Topic T02 = new Topic() { Name = "L2E" };


            //Console.WriteLine(dbContext.Entry(T01).State); // Detached

            //dbContext.Add(T01);
            //dbContext.Add(T02);

            //Console.WriteLine(dbContext.Entry(T01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(T01).State); // Unchanged 
            #endregion

            #region Select

            //var topic = (from T in dbContext.Topic
            //             where T.Id == 2
            //             select T).FirstOrDefault();
            //Console.WriteLine(topic?.Name ?? "NA");
            #endregion

            #region Update

            //Console.WriteLine(dbContext.Entry(topic).State); // Unchanged

            //topic.Name = "Test";

            //Console.WriteLine(dbContext.Entry(topic).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(topic).State); // Unchanged

            #endregion

            #region Delete

            //Console.WriteLine(dbContext.Entry(topic).State); // Unchanged

            //dbContext.Remove(topic);

            //Console.WriteLine(dbContext.Entry(topic).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(topic).State); // Detached
            #endregion
            #endregion

            #region Courses
            #region Insert
            //Course Crs01 = new Course() { Name = "C#", Duaration = 5 };
            //Course Crs02 = new Course() { Name = "LINQ", Duaration = 2, TopicId = 1 };


            //Console.WriteLine(dbContext.Entry(Crs01).State); // Detached

            //dbContext.Add(Crs01);
            //dbContext.Add(Crs02);

            //Console.WriteLine(dbContext.Entry(Crs01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Crs01).State); // Unchanged

            #endregion

            #region Select

            //var course = (from Crs in dbContext.Courses
            //              where Crs.Id == 2
            //              select Crs).FirstOrDefault();

            ////Console.WriteLine(course?.Name ?? "NA");
            #endregion

            #region Update
            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged

            //course.Name = "OOP";

            //Console.WriteLine(dbContext.Entry(course).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged
            #endregion

            #region Delete
            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged

            //dbContext.Remove(course);

            //Console.WriteLine(dbContext.Entry(course).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(course).State); // Detached

            #endregion
            #endregion

            #region Student_Course

            #region Insert
            //StudentCourse SC01 = new StudentCourse() { CourseId = 1, StudentId = 1, Grade = 100 };
            //StudentCourse SC02 = new StudentCourse() { CourseId = 2, StudentId = 1, Grade = 80 };

            //Console.WriteLine(dbContext.Entry(SC01).State); // Detached

            //dbContext.Add(SC01);
            //dbContext.Add(SC02);

            //Console.WriteLine(dbContext.Entry(SC01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(SC01).State); // Unchanged 
            #endregion


            #endregion

            #endregion


        }
    }
}
