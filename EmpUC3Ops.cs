using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC3Ops
{
    public class EmpUC3Ops
    {

        public int partTime;
        public int FullTime;
        public int Emp_Wage_Hour; 
        public int emphrs;
         public  void uc3(int partTime, int FullTime, int Emp_Wage_Hour, int emphrs)
        {

            int partTime1 = partTime;

            int FullTime2 = FullTime;

            int Emp_Wage_Hour2 = Emp_Wage_Hour;

            int emphrs2 = emphrs;

            Random random = new Random();

            int num = random.Next(3);

            if (num == partTime1)
            {
                emphrs2 = 4;
            }

            else if (num == FullTime2)
            {
                emphrs2 = 8;
            }

            else
            {
                emphrs2 = 0;
            }

            int Cal = Emp_Wage_Hour2 * emphrs2;

            Console.WriteLine("per day wage" + Cal);

        }
    }
}
