using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class Basketball : Sport {
        public override string GetRules() {
            return "Player should handle ball with their hands, kicking is not allowed, if ball was shot from 25 feet => it's 3point line";
        }

        public override string Name() {
            return "Basketball";
        }

        public override void Play() {
            Console.WriteLine("Play basket ball");
        }

        public override void Practice() {
            Console.WriteLine("Practicing 3pt shots");
        }
    }
}
