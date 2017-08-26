namespace _03.Mankind
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var studentInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var studentFirstName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var facultyNumber = studentInfo[2];

            var workerInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var salary = decimal.Parse(workerInfo[2]);
            var hours = double.Parse(workerInfo[3]);

            try
            {
                var student = new Student(studentFirstName, studentLastName, facultyNumber);
                var worker = new Worker(workerFirstName, workerLastName, salary, hours);

                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}