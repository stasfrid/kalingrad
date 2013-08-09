using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Kalingrad
{
    class LeftShape
    {

        public List<Vector2> points;

        public int lastSelectedPoint;

        private List<Point> rightEdges;

        public List<Point> myEdges;

        public LeftShape(RightShape rightShape)
        {
            this.points = new List<Vector2>();
            for (int i = 0; i < rightShape.points.Count; i++)
            {
                points.Add(new Vector2(rightShape.points[i].X - 400, rightShape.points[i].Y));
            }

            rightEdges = new List<Point>(rightShape.edges);
            this.myEdges = new List<Point>();

            this.lastSelectedPoint = -1;
        }

        internal void AddClick(int currentSelectedPoint)
        {
            if (currentSelectedPoint == lastSelectedPoint) return;

            if (lastSelectedPoint != -1)
            {
                Point newEdge = new Point(lastSelectedPoint, currentSelectedPoint);
                if (!containsEdge(newEdge))
                {
                    myEdges.Add(newEdge);
                    lastSelectedPoint = currentSelectedPoint;
                }
                return;
            }

            lastSelectedPoint = currentSelectedPoint;
        }

        public bool HasWon()
        {
            foreach (Point edge in this.rightEdges)
            {
                if (!containsEdge(edge, myEdges)) return false;
            }

            foreach (Point edge in this.myEdges)
            {
                if (!containsEdge(edge, this.rightEdges)) return false;
            }

            return true;
        }

        private bool containsEdge(Point edge)
        {
            return containsEdge(edge, this.myEdges);
        }

        private bool containsEdge(Point edge,List<Point> checkEdges)
        {
            foreach (Point myEdge in checkEdges)
            {
                if (((myEdge.X == edge.X) || (myEdge.X == edge.Y)) && ((myEdge.Y == edge.Y) || (myEdge.Y == edge.X)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
