using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {

    class Action {
        public string Name { get; set; }

        public void Undo() {

            Console.WriteLine($"Undo self: {this.Name}");
        }
    }
    class PaintHistory {

        private static PaintHistory shared;
        public static PaintHistory Shared() {
            if(shared == null) shared = new PaintHistory();
            return shared;
        }

        Action[] history = new Action[100];
        int lastAction = 0;


        public void SaveAction(Action action) {
            history[lastAction++] = action;
        }

        public void Rollback() {
            if(this.lastAction > 0) {
                history[--lastAction].Undo();
            }
        }
    }
}
