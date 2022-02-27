using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC2Oops;

public class EmpUC2Ops
{

    public void u2c(int EmployeeWagePerHour, int FullDayWage)

    {
        int FullDayWage1 = FullDayWage;

        int EmployeeWagePerHour2 = EmployeeWagePerHour;






        Random random = new Random();
        int num = random.Next(2);

        if (num == 1)
        {
            float Calculate = (EmployeeWagePerHour2 * FullDayWage1);
            Console.WriteLine("Per Day Wage" + Calculate);

        }

        else
        {

            int Calculate = 0;

            Console.WriteLine("PerDay Wage" + Calculate);
        }
    }
}

