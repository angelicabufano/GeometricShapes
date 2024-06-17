using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes;
internal class Rect : Quad {

    public new int Area() {
        return Side1 * Side2;
    }

    public Rect(int side1, int side2) : base(side1, side2, side1, side2) {
        Side1 = side1;
        Side2 = side2;
    }
}
