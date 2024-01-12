using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExerciseOOP
{
    internal class Car
    {
        //public string regNr;
        //public string make;
        //public string model;
        //public int year;
        //public bool forSale;

        private string regNr;
        private string make;
        private string model;
        private int year;
        private bool forSale;

        public string RegNr
        {
            get { return regNr; }
            set { regNr = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set 
            {
                if ((value < 1990))
                {
                    year = -1;
                }
                else
                {
                    year = value;
                }
            }
        }

        public bool ForSale
        {
            get { return forSale; }
            set { forSale = value; }
        }

        public String YearToString()
        {
            if(this.year == -1)
            {
                return "Incorrect year";
            }
            else
            {
                return Convert.ToString(year);
            }
        }

        public Car()
        {

        }

        public Car(string regNr, string make, string model, int year, bool forSale)
        {
            this.regNr = regNr;
            this.make = make;   
            this.model = model;
            this.year = year;
            this.forSale = forSale;
        }

        public override String ToString()
        {
            return String.Format("\nCar Info\nReg: {0}, {1} {2} [{3}]\n{4}",
                this.regNr, this.make, this.model, this.YearToString(), this.ForSaleToString());
        }

        public String ForSaleToString()
        {
            if (this.ForSale)
            {
                return "Car is for sale.";
            }
            else
            {
                return "Car is not for sale.";
            }
        }
    }
}
