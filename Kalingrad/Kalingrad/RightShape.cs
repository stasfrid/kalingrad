using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Kalingrad
{
    public class RightShape
    {
        public List<Vector2> points;

        public List<Point> edges;

        public RightShape(List<Vector2> points, List<Point> edges)
        {
            this.points = points;
            this.edges = edges;
        }
    }
}
