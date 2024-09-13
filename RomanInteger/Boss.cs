using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {
    internal class Boss {

        public void WinningBehavior() {
            PaintHistory.Shared().SaveAction(new Action { Name = "boss" });
            PaintHistory.Shared().Rollback();
        }
    }
}
