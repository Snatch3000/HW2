using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car= new Car("Lada", "D");
            car.Color= Color.Brown;

            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Водитель не назначен");
            }

            Driver dr= new Driver(new DateTime(1998, 11, 22), "Voldemar");
            dr.Category= new List<string>() {"B", "C"};
            try
            {
                car.ChangeOwner(dr, "o777oo");
            }
            catch (NoCategoryException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
            
            dr.Category.Add("D");
            car.ChangeOwner(dr, "o777oo");
            Console.WriteLine(dr.Car.CarNumber);
            Console.WriteLine(car.CarPassport.Owner.Name);
            
            Console.ReadKey();
        }
    }
}
