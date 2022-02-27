using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC8
{
    public class U8C
    {

        public const int PartTime=1;

        public const int fullTime = 2;

        public static void UC8(string company, int emprateperhr,int numOfworkingdays,int Maxhrpermon)
        {


            int emphrs = 0; int totalhrs = 0; int numofworkingdays = 0;

            while(totalhrs<Maxhrpermon && numofworkingdays<numOfworkingdays)
            {
                numofworkingdays++;

                Random random = new Random();
                int num = random.Next(0, 3);

                switch(num)
                {
                    case PartTime:

                       emphrs = 4;
                        break;

                    case fullTime:
                        emphrs = 8;
                        break;

                    default:

                        emphrs = 0;
                        break;


                }

                totalhrs = totalhrs + emphrs;

               
            }

            int totalempwage = totalhrs * emprateperhr;

            Console.WriteLine(totalempwage);


        }
    }
}
