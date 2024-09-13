using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class Football : Sport {
        public override string Name() {
            return "Football";
        }

        public override string GetRules() {
            return "Team who scores more goals - win";
        }

        public override void Play() {
            Console.WriteLine("play football");
        }

        public override void Practice() {
            Console.WriteLine("dribbling practice");
        }
    }
}
