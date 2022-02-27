using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpUC1ops
{
    public class EmpOUC1
    {

        public int s;
        public int v;
        public void u1c()

        {
            s = 1;
            v = 0;

            Random random = new Random();
            int c = random.Next(2);

            if ( c==1)
            {
                Console.WriteLine("Present");
            }

            else
            {
                Console.WriteLine("absent");
            }
        }

    }
}
