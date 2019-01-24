using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public class Flash : Storage
    {
        public double SpeedOfUSB { get; set; }
        public double Memory { get; set; }

        public override double GetMemory()
        {
            return Memory;
        }
        public override int GetTimeOfWriting()
        {
            return (int)(Memory / SpeedOfUSB);
        }
        public override string GetAllInfo()
        {
            return $"{NameOfCarrier}-{Model}-Speed of USB {SpeedOfUSB}-" +
                   $"Memory {Memory}";
        }

    }
}
