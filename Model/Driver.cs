using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Model
{
    public class Driver
    {
        private readonly DateTime _licenseDate;
        private readonly string _name;
        

        public Driver(DateTime date, string name)
        {
            _licenseDate = date;
            _name = name;
            
        }

        public DateTime LicenseDate
        {
            get { return _licenseDate; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int Experience
        {
            get
            {
                DateTime d1 = _licenseDate;
                DateTime d2 = DateTime.Now;
                return (d2 - d1).Days/365;
               
            }
        }

        public List<string> Category {get; set; }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            
                if (Category.Contains(car.Categor))
                {
                    Car = car;
                    
                }
                else 
                {
                    throw new NoCategoryException($"Водитель {Name} не имеет нужной категории {car.Categor}");
                }
                
                
            }
            
        }
    }

