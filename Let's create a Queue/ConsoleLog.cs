using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_create_a_Queue
{
    public class ConsoleLog : ILogger
    {
        public void LogSum(ISum sum)
        {
            Console.WriteLine(sum.Sum());
        }
    }
}
