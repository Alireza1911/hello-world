using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
   public class Case
    {
        public Cooling Cooling { get; set; }

        public RAM RAM { get; set; }

        public MotherBoard MotherBoard { get; set; }

        public GraphicCard GraphicCard { get; set; }

        public Cpu Cpu { get; set; }

        public void moshkhsat()
        {
            Console.Write($"cooling={Cooling.cooling}\tRAM={RAM.RAMDDR}DDR\tmotherboard={MotherBoard.motherBoard}\tgraphiccard={GraphicCard.GCModel}\tCpu={Cpu.Haste}hastei");
        }

    }
}
