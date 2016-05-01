using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VimeoDotNet;

namespace Demo {
    class Program {
        static void Main(string[] args) {            
            VimeoClient vc = new VimeoClient("ff0d85503ccd7e9136751d5f593eb340");
            var sw = new Stopwatch();
            sw.Start();
            var res= vc.GetVideosAsync("RUSSIA",1,10).Result;
            sw.Stop();
            Console.WriteLine($"Query time took {sw.ElapsedMilliseconds}");
            int i=0;
            foreach(var r in res.data) {
                Console.WriteLine($"LOADING VIDEO {i} #####################################################");
                Console.WriteLine($"Video desc: {r.description}, video length: {r.duration}, video title: {r.name}, total views {r.stats.plays}");
                Console.WriteLine();
                i++;
            }
            Console.ReadLine();
        }
    }
}
