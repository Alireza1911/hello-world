using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
  public class RAM
    {
        public RAM(int DDR)
        {
            this.RAMDDR = DDR;
        }
        public int RAMDDR { get; set; }
    }
}
