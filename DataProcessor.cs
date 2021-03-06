﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
   public abstract class DataProcessor
    {
        public void ReadProcessSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }
        public abstract void ReadData();
        public abstract void ProcessData();
        public void SaveData()
        {
            Console.WriteLine("Save Data to DB");
        }
    }

}
