using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC4Ops
{
    public class u4c
    {
        public static int PartTime;
        public static int FullTime;
        public static int WageHour;

        public static int Emphrs;

        public  void EU4c(int PartTime,int FullTime,int WageHour,int Emphrs)
        {

            int PartTime1=PartTime;

            int FullTime2 = FullTime;
            int WageHour3 = WageHour;

            int Emphrs4 = Emphrs;

             Random random = new Random();
            int num = random.Next(3);
            
            switch (num)
            {
                case 1:
                    Emphrs4 = 4;
                    break;

                case 2:
                    Emphrs4 = 8;
                    break;

                default:
                    Emphrs4 = 0;
                    break;
            }

            int Cal = WageHour3 * Emphrs4;

            Console.WriteLine("Per dayage" + Cal);


        }
    }
}
