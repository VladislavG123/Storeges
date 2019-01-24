using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
     public class DVD : Storage
    {
        public double WriteSpeed { get; set; }
        public double ReadSpeed { get; set; }
        public bool isTwoSided { get; set; }

        private const double VOLUME_TWO_SIDED = 4.7;
        private const double VOLUME_ONE_SIDED = 9; 

        public override double GetMemory()
        {
            return isTwoSided ? VOLUME_TWO_SIDED : VOLUME_ONE_SIDED;
        }
        public override int GetTimeOfWriting()
        {
            return (int)((isTwoSided ? VOLUME_TWO_SIDED : VOLUME_ONE_SIDED) / WriteSpeed);
        }
        public override string GetAllInfo()
        {
            return $"{NameOfCarrier}\n{Model}\nSpeed of Writing {WriteSpeed}\n" +
                   $"Speed of Reading {ReadSpeed}\n{(isTwoSided? "Two" : "One")}-Sided";
        }
    }
}
