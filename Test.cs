using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
 public  class Test :DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read Data from test file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Data from test file");
        }

    }
}
