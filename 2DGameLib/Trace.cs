using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameLib
{
    class Trace
    {
        public static TraceSource ts = new TraceSource("Application");

        static Trace()
        {
            ts.Switch = new SourceSwitch("Application Log", "All");

            string txt = "ApplicationLog.txt";
            string path = Environment.GetEnvironmentVariable("2DGameFrameworkConfig");
            string fullPath = Path.Combine(path, txt);

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter(fullPath));
            fileLog.Filter = new EventTypeFilter(SourceLevels.All);
            ts.Listeners.Add(fileLog);
        }

        public static void Log()
        {
            ts.TraceEvent(TraceEventType.Information, 555, "This is information");
            ts.TraceEvent(TraceEventType.Error, 555, "This is an error");
            ts.TraceEvent(TraceEventType.Critical, 555, "This is critical");
            ts.TraceEvent(TraceEventType.Warning, 555, "This is a warning");

            ts.Close();
        }
    }
}
