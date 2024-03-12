using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_RobotDb.Models
{
    internal class Torso
    {
        public Material Material { get; set; }
        public ChestMeasurements ChestMeasurements { get; set; }
        public WaistMeasurements WaistMeasurements { get; set; }
    }
}
