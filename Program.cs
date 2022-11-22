using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elipse anElipse = new Elipse();

            anElipse.MajorRad = 3;
            anElipse.MinorRad = 2;

            Console.WriteLine(anElipse.Area());

            Circle aCircle = new Circle();

            aCircle.MajorRad = 3;
            aCircle.MinorRad = 2;



            Console.ReadKey();

        }
    }


}
