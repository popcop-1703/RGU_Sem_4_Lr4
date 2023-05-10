using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_lab4_
{

    enum TariffType {FREE, BUSY}


    internal class tariff
    {
        private string number;
        public double cost;
        public string Person;
        private TariffType tariffType;
        public tariff(string number, double cost)
        {
            this.number = number;
            this.cost = cost;
            tariffType = TariffType.FREE;
        }
        public TariffType TR
        { 
            get { return tariffType; }
            set { tariffType = value; }
        }
        public string Number{ get { return number; } }
        public double Cost{ get { return cost; } }
    }
}
