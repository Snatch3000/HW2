using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Model
{
     public class Car 
     {
         private readonly string _model;
         private readonly string _categor;
         private readonly CarPassport _carPassport;
         

         public Car(string model, string categor)
         {
             _model = model;
              Color = Color.Blue;
            _categor = categor;
            _carPassport=new CarPassport(this);
         }

         public string Model
         {
             get { return _model; }
         }

         public Color Color { get; set; }

         public string CarNumber { get; private set; }

         public string Categor
         {
             get { return _categor; }
         }

         public CarPassport CarPassport
         {
             get { return _carPassport; }
         }

         public void ChangeOwner(Driver driver, string newnumber)
         {
             if (driver.Category.Contains(Categor))
             {
                CarPassport.Owner = driver;
                driver.OwnCar(this);
                CarNumber = newnumber;
             }

             else
             {
                throw new NoCategoryException($"Водитель {driver.Name} не имеет нужной категории {Categor}");
            }

            
            
         }
     }
}

