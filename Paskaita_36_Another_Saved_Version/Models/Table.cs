using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Paskaita_Restaurant_System.Models
{
    internal class Table
    {
        public int TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsOccupied { get; set; }

        public Order CurrentOrder { get; set; }

        public Table(int tableNumber, int numberOfSeats)
        {
            TableNumber = tableNumber;
            NumberOfSeats = numberOfSeats;
            IsOccupied = false;
            CurrentOrder = null;
        }

        public void OccupyTable()
        {
            IsOccupied = true;
        }

        public void VacateTable()
        {
            IsOccupied = false;
        }

    }


}
