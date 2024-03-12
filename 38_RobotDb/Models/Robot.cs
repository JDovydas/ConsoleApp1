using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_RobotDb.Models
{
    internal class Robot
    {
        public Guid Id { get; set; }
        public List<Arm> Arms { get; set; }

        public List<Leg> Legs { get; set; }

    }
}
