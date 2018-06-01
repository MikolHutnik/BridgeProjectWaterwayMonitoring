using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProjectWaterwayMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {

            RiverInfo RiverData  = new RiverInfo("Ohio", 25, 4);
            RiverData.GetStatus();
            RiverData.RivName();
            RiverData.Depth();
            RiverData.Clean();
        }
    }
}
