using System;
using System.Collections.Generic;
using System.Text;

namespace UpCast_DownCast.Models
{
    internal class Celsius
    {
        public int Degree { get; set; }
        public Celsius(int cls)
        {
            Degree = cls;
        }
        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Degree + 273);
        }

    }
}
