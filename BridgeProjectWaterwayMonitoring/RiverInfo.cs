using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProjectWaterwayMonitoring
{
    class RiverInfo
    {
        //declare fields
        private string riverName;
        private int riverDepth;
        private int currentPollutionLevel;
        private string newPollutionLevel;
        //private int pollutionStatus; 
        // private int riverStatus;    

        //declare properties

        public string RiverName
        {
            get { return this.riverName; }
            set { this.riverName = value; }
        }

        public int RiverDepth
        {
            get { return this.riverDepth; }
            set { this.riverDepth = value; }
        }

        public int CurrentPollutionLevel
        {
            get { return this.currentPollutionLevel; }
            set { this.currentPollutionLevel = value; }
        }

        public string NewPollutionLevel
        {
            get { return this.newPollutionLevel; }
            set { this.newPollutionLevel = value; }
        }

        //default constructor
        public RiverInfo()
        {

        }

        //loaded constructor
        public RiverInfo(string riverName, int riverDepth, int currentPollutionLevel)
        {
            this.riverName = riverName;
            this.riverDepth = riverDepth;
            this.currentPollutionLevel = currentPollutionLevel;            
        }

        //random num gen
        public void GetStatus()
        {
            
            Random r = new Random();
            this.RiverDepth = r.Next(10, 40);
            this.CurrentPollutionLevel = r.Next(1, 10);
            
        }

        //unsafe depth level warning
        public void Depth()
        {
            if (riverDepth > 30)
            {
                Console.WriteLine("Water level High!");
                DepthChange();
            }
              
        }
        // make a change to river depth
        public void DepthChange()
        {
            Console.WriteLine("Please enter a new depth of the river?");
            RiverDepth = int.Parse(Console.ReadLine());
            Console.WriteLine("The new depth of the river is: {0}", RiverDepth);
        }


        //unsafe pollution levels
        public void Clean()
        {
            if (currentPollutionLevel >= 8)
            {
                Console.WriteLine("Pollution levels critical!");
                RiverClean();
            }
        }

        //make a change to pollution level
        public void RiverClean()
        {
            Console.WriteLine("Will you clean the river?");
            newPollutionLevel = (Console.ReadLine());
            Console.WriteLine("The river has been cleaned!");
        }

        // create river name
        public void RivName()
        {
            Console.WriteLine("You are at the Ohio river!");
            GetCurrDepth();
            GetCurrPol();
        }

        public void GetCurrDepth()
        {
            Console.WriteLine("Current river depth {0} Feet",riverDepth);
        }

        public void GetCurrPol()
        {
            Console.WriteLine("Current level of pollution {0}",currentPollutionLevel);
        }

    }

}
