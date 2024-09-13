using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {

    struct Vector2 {
        public float x;
        public float y;
    }

    class MathHelper {

        // pure function
        public static Vector2 Add(Vector2 v1, Vector2 v2) {
            return new Vector2 { x = v1.x + v2.x, y = v1.y + v2.y };
        }
    }
}
