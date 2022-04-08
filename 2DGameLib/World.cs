using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    public class World 
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public World()
        {

        }

        public void GetConfiguration()
        {
            ReadConfiguration.ReadConfig();
            MaxX = ReadConfiguration.MaxWorldSize;
            MaxY = ReadConfiguration.MinWorldSize;

            Trace.ApplicationLog(TraceEventType.Information, "The world was created with x and y values");
        }
    }
}
