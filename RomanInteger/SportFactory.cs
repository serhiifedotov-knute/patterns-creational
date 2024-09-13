using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    class SportFactory {

        public static Sport CreateSport(int dayOfMonth) {
            if(dayOfMonth % 2 == 0) {
                return new Football();
            } else {
                return new Basketball();
            }
        }
    }
}
