using EmployeeOOEDI.Classes;
using System;


namespace EmployeeOOEDI
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, World!");
                // declarar variables
                int day, month, year;

                Console.Write("Ingresar el Dia ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el Mes ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el Año ");
                year = Convert.ToInt32(Console.ReadLine());



                // inst la clase date.cs
                Date dateObject = new Date(year, month, day);
                Console.Write("\n");
                Console.WriteLine(dateObject.ToString());//23/50/2200

            }
            catch (Exception ex)
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}