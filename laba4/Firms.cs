using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_lab4_
{
    static class Firms
    {
        private static List<tariff> rooms = new List<tariff>();
        private static List<Person> persons = new List<Person>();

        internal static tariff tariff
        {
            get => default;
            set
            {
            }
        }

        internal static Person Person
        {
            get => default;
            set
            {
            }
        }

        internal static Person Person1
        {
            get => default;
            set
            {
            }
        }

        /*public static List<Room> Rooms
        {
            set;
            get;
        }
        public static List<Person> Persons {
            set;
            get;
        }*/
        public static void showTariffs(DataGridView data, int index)
        {
            foreach (Person person in persons)
                    if (person.room.TR == TariffType.BUSY)
                {
                    data.Rows.Add();
                    data.Rows[index].Cells[0].Value = person.room.Number;
                    data.Rows[index].Cells[1].Value = person.room.Cost * person.massa;
                    index++;
                }
        }
        public static bool addTariff(tariff room)
        {
            foreach (tariff r in rooms)
            {
                if (r.Number == room.Number) 
                    return false; 
            }
            rooms.Add(room);
            return true;
                
        }
        public static string addPerson(string firstname, string lastName, string number, double massa, double cost)
        {
            foreach(tariff room in rooms)
            {
                if (room.Number == number)
                {
                        Person person = new Person(firstname, lastName, number, massa);
                        person.ROOM = room;
                        persons.Add(person);
                        room.TR = TariffType.BUSY;
                        person = null;
                        return "Клиент зарегистрирован";
                }
            }
            return "Такого тарифа нет";
        }
        public static double store(string last, string first)
        {
            foreach (Person person in persons)
                if (person.Lastname.Equals(last) && person.Firsname.Equals(first)) 
                    return person.ROOM.Cost * person.massa;
            return -1;
        }
    }
}
