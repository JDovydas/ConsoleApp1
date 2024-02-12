using _36_Paskaita_Restaurant_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Part2_Restaurant_Solution_Structured.Services
{
    internal class TableService
    {
        public void OccupyTable(Table table)
        {
            table.IsOccupied = true;
        }

        public void VacateTable(Table table)
        {
            table.IsOccupied = false;
        }
    }
}
