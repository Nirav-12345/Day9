using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EUC5Ops
{
    public class U5C
    {
        public static int PartTime;

        public static int FullTime;

        public static int Wagehour;

        public static int workingDays;

        public static int emphrs;


        



public void eUC5(int PartTime, int FullTime, int Wagehour, int workingDays, int emphrs)



            


       
        {
            





            int totalsalary = 0;


            for (int day = 1; day <= workingDays; day++)
            {

                Random random = new Random();
                int num = random.Next(3);


                switch (num)
                {
                    case 1:
                        emphrs = 4;
                        break;


                    case 2:
                        emphrs = 8;
                        break;

                    default:

                        emphrs = 0;
                        break;





                }

                int salary = (emphrs * Wagehour);

                 totalsalary = (salary + totalsalary);

                Console.WriteLine("Total Salary" + totalsalary);

            }









        }
    }
}
