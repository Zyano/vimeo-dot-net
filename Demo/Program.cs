using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VimeoDotNet;

namespace Demo {
    class Program {
        static void Main(string[] args) {
            VimeoClient vc = new VimeoClient("b9825a2a07238415113f82b6f169fbe1");
            var res = vc.GetUserVideos(null,null, 2, "Russia");
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
