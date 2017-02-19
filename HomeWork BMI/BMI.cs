using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BMI
{
    class BMI
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public double add()
        {
            return Weight / (Height * Height);

        }
    }
}
