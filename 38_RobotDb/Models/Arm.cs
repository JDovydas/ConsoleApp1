using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_RobotDb.Models
{
    internal class Arm
    {
        public Material Material { get; set; }
        public int NumberOfJoints { get; set; }
        public int NumberOfFingers { get; set; }
    }
}
