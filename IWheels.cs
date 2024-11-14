using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public interface IWheels
    {
        int MaxRimSize { get; set; }
        void SetTireType(bool isWinterTire);
        string Info() => "Brug mig for alle objekter som køres på hjul.";
    }
}

