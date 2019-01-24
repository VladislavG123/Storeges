using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public  class HDD : Storage
    {
        public int SpeedOfUSB { get; set; }
        public int AmountSections { get; set; }
        public int VolumeSection { get; set; }

        public override double GetMemory()
        {
            return VolumeSection * AmountSections;
        }
        public override int GetTimeOfWriting()
        {
            return (AmountSections * VolumeSection) / SpeedOfUSB;
        }
        public override string GetAllInfo()
        {
            return $"{NameOfCarrier}\n{Model}\nSpeed of USB {SpeedOfUSB}\n" +
                   $"Amount Sections {AmountSections}\nVolum Siction {VolumeSection}";
        }
    }
}
