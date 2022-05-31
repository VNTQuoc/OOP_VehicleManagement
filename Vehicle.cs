using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicle
{
    public class Vehicle
    {
        private string OwnerName;
        private string TypeofVehicle;
        private double Cylinder;
        private double Price;
        private double Tax;
      

        public Vehicle()
        { }
        public Vehicle(string OwnerName, string TypeofVehicle, double Cylinder, double Price)
        {
            this.OwnerName = OwnerName;
            this.TypeofVehicle = TypeofVehicle;
            this.Cylinder = Cylinder;
            this.Price = Price;
            
        }

   

        public string Name()
        {
            return OwnerName;
        }
        public string Type()
        {
            return TypeofVehicle;

        }
        public double Xilanh()
        {
            return Cylinder;
        }
        public double Pay()
        {
            return Price;
        }


        public void OwnerNameset(string OwnerName)
        {
            this.OwnerName = OwnerName;
        }
        public void VehicleTypeset(string TypeofVehicle)
        {
            this.TypeofVehicle = TypeofVehicle;
        }
        public void Cylinderset(int Cylinder)
        {
            this.Cylinder = Cylinder;
        }
        public void Priceset(double Price)
        {
            this.Price = Price;
        }
        public double Taxcout()
        {
            if(Cylinder < 100)
            {
                this.Tax = 0.01 * this.Price;
            }    
            else if(Cylinder >= 100 && Cylinder < 200)
            {
                this.Tax = 0.03 * this.Price;
            }    
            else
            {
                this.Tax = 0.05 * this.Price;
            }    
            return this.Tax;
        }
        public void Show()
        {
            Console.WriteLine(this.toString());
        }
        public string toString()
        {
            return String.Format("{0} \t{1} \t\t{2} \t\t\t{3} \t\t{4}", this.OwnerName, this.TypeofVehicle, this.Cylinder, this.Price, this.Taxcout());
        }

    }
}