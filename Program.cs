using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {

            Excell obj= new Excell();
            obj.ReadProcessSave();

            Test obj1 = new Test();
            obj.ReadProcessSave();
        }
    }
}
