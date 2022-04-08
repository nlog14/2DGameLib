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
        public Position PositionX { get; set; }
        public Position PositionY { get; set; }

        public World(Position positionX, Position positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            GetConfiguration();
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
