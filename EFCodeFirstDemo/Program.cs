
using EFCodeFirstDemo.Entities;

namespace EFCodeFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFCoreDBContext();
            /*try
            {
                var student = new Student()
                {
                    FirstName = "Rahul",
                    LastName = "Rout",
                    DateOfBirth = new DateTime(1988, 02, 29),
                    Height = 5.80M,
                    Weight = 70
                };

                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Added succesfully to DB");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }*/
            /*
            var student = context.Students.Find(1);

            if (student != null)
            {
                student.DateOfBirth = new DateTime(1995, 02, 14);
                context.SaveChanges();
                Console.WriteLine("Updated succesfully to DB");
            }*/

            var student = context.Students.Find(1);

            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                Console.WriteLine("Deleted succesfully");
            }


        }
    }
}