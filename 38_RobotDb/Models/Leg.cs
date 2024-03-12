using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_RobotDb.Models
{
    internal class Leg
    {
        public Material Material { get; set; }
        public int NumberOfJoints { get; set; }
        public float SizeOfFoot { get; set; }
    }
}
