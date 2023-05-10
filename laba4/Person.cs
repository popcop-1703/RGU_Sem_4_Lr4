using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_lab4_
{
    internal class Person
    {
        public string firstname;
        public string lastname, number;
        public double massa;
        public tariff room;
        public Person(string firstname, string lastname, string number, double massa)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.number = number;   
            this.massa = massa;
        }
        public string Firsname{ get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public tariff ROOM {
            get { return room; }
            set { room = value; }
        }

        internal TariffType TariffType
        {
            get => default;
            set
            {
            }
        }

        internal tariff tariff
        {
            get => default;
            set
            {
            }
        }
    }
}
