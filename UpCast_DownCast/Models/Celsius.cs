using System;
using System.Collections.Generic;
using System.Text;

namespace UpCast_DownCast.Models
{
    internal class Celsius
    {
        public int Cls { get; set; }
        public Celsius(int cls)
        {
            Cls = cls;
        }
        public static implicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.Cls + 273);
        }

    }
}
