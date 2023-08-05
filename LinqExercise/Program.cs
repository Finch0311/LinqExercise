using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //done TODO: Print the Sum of numbers
            Console.Write("Sum of array : ");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //done TODO: Print the Average of numbers
            Console.Write("Average of array : ");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();
            //done TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending order of array : ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            //done TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Descending order of array : ");
            var orderOfDescent = numbers.OrderByDescending(x => x);

            foreach (var x in orderOfDescent)
            {
                Console.WriteLine(x); 
            }
            Console.WriteLine();
            //done TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers in array that are greater than 6 : ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            //done TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Four numbers of the array in order : ");
            var print4 = numbers.OrderBy(x => x).Take(4);
            foreach (var item in print4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //done TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Changing value of index [4] to age and ordered in descent : ");
            numbers.SetValue(30, 4);
            foreach(var item in orderOfDescent)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //done  List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //done TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Names that start with C or S in employee list : ");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S')).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName)); ;

            //done TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine();


            Console.WriteLine("Employees age over 26 and in order : ");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.FullName} Age: {x.Age}"));
            Console.WriteLine();
            //done TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of employee exp : ");
            var employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine("Average of employee exp : ");
            var employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAvg);
            Console.WriteLine();
            //done TODO: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("New employee : ");
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Colby";
            newEmployee.LastName = "Finch";
            newEmployee.Age = 30;
            newEmployee.YearsOfExperience = 1;

            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
