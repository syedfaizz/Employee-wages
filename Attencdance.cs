using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage.Employee_wages
{
    class Attencdance
    {
        /// <summary>
        /// This method is used to check whether employee is present or not.
        /// </summary>
        public void attendance()
        {
            Random rd = new Random();
            int empCheck = rd.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is present.");
            else
                Console.WriteLine("Employee is absent.");
        }
    }
}


    {
    }
}
