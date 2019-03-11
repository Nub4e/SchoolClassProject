using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class Mark
    {
        private double number;
        private string description;
        public double Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = GetD(this.number);
            }
        }
        public Mark(double number)
        {
            Number = number;
            Description = string.Empty;
        }
        string GetD(double number)
        {
            if (this.Number >= 2 || this.Number <= 6)

            if (this.Number >= 2 && this.Number<3)
            {
                return "Weak";
            }
            if (this.Number >= 3 && this.number<3.50)
            {
                return "Not good";
            }
            if (this.Number >= 3.50 && this.Number<4.50)
            {
                return "Good";
            }
            if (this.Number >= 4.50 && this.Number<5.50)
            {
                return "Very good";
            }
            if (this.Number >= 5.50 && this.Number<=6)
            {
                return "Excelent";
            }
            else return "Wrong mark";
        }
        public override string ToString()
        {
            return string.Format("{0:f2};{1}",this.Number,this.Description);
        }


    }
}

