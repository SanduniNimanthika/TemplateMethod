using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
   public class Excell :DataProcessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read Data");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Data");
        }
        
    }
}
