using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    public class Program
    {
        public double AllMemory(Storage[] storages)
        {
            double memory = 0;
            foreach (var storage in storages)
            {
                memory += storage.GetMemory();
            }
            return memory;
        }

        public bool isEnoughMemory(Storage[] storages, double memoryOnPC)
        {
            return AllMemory(storages) >= memoryOnPC ? true : false;
        }

        

        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            dvd.isTwoSided = true;
            dvd.Model = "DVD-R";
            dvd.NameOfCarrier = "DVD Makers";
            dvd.ReadSpeed = 123123;
            dvd.WriteSpeed = 2;
            Console.WriteLine(dvd.GetAllInfo());
            Console.Read();
        }
    }
}
