using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class Program
    {
        static void Main(string[] args)
        {
            CaseTower a = new CaseTower();
            a.Cooling.cooling = "watercooling";
            a.Cpu.Haste = 4;
            a.GraphicCard.GCModel = "majaza";
            a.MotherBoard.motherBoard = "mojaza";
            a.RAM.RAMDDR = 4;
            a.moshkhsat();
        }
    }
}
