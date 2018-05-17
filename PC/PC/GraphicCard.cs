using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class GraphicCard
    {
        public GraphicCard(string GCModel)
        {
            this.GCModel = GCModel;
        }
        public string GCModel { get; set; }
    }
}
