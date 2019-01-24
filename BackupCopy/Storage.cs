using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public abstract class Storage
    {
        public string NameOfCarrier { get; set; }
        public string Model { get; set; }

        public abstract double GetMemory();
        public abstract string GetAllInfo();
        public abstract int GetTimeOfWriting();
    }
}
