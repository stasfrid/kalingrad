using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Kalingrad
{
    class RandomShapeGenerator
    {
        public static RightShape GenerateShape(int numPoints)
        {
            Random rand = new Random();

            List<Vector2> points = new List<Vector2>();

            // points

            for (int i = 0; i < numPoints; i++)
            {
                Vector2 newPoint;

                do
                {
                    newPoint = new Vector2((float)(rand.Next(Game1.WIDTH / 2 - 100) + (Game1.WIDTH / 2+50))
                        , (float)(rand.Next(Game1.HEIGHT/2)+50));

                } while (intersectWithPoints(newPoint, points));

                points.Add(newPoint);
            }

            // edges
            List<Point> edges = genarateEdges(numPoints);


            return new RightShape(points, edges);
        }

        private static List<Point> genarateEdges(int p)
        {
            int numEdges = p+(p/2);
            Random rand = new Random();

            List<Point> toRet = new List<Point>(numEdges);

            do
            {
                toRet.Clear();

                for (int i = 0; i < numEdges; i++)
                {
                    Point newEdge;
                    do
                    {
                        newEdge = new Point(rand.Next(p), rand.Next(p));
                    } while (containsEdge(newEdge, toRet) || (newEdge.X == newEdge.Y));

                    toRet.Add(newEdge);
                }
            } while (!legalEdges(toRet));

            return toRet;
        }

        private static bool legalEdges(List<Point> toRet)
        {
            int[] degrees = new int[toRet.Count];
            foreach (Point point in toRet)
            {
                degrees[point.X]++;
                degrees[point.Y]++;
            }

            // check odd degrees
            int odds = 0;
            for (int i = 0; i < degrees.Length; i++)
            {
                if (degrees[i] % 2 != 0) odds++;
            }

            return (odds == 0 || odds == 2);
        }

        private static bool intersectWithPoints(Vector2 newPoint, List<Vector2> points)
        {
            foreach (Vector2 point in points)
            {
                if (point != newPoint)
                {
                    if (intersectPoints(point, newPoint)) return true;
                }
            }

            return false;
        }


        private static bool containsEdge(Point edge, List<Point> checkEdges)
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

        private static bool intersectPoints(Vector2 point, Vector2 newPoint)
        {
            Rectangle oneRect = new Rectangle((int)(point.X) - 10, (int)point.Y - 10,20,20);

            Rectangle twoRect = new Rectangle((int)newPoint.X - 10, (int)newPoint.Y - 10, 20, 20);

            return (Rectangle.Intersect(oneRect, twoRect) != Rectangle.Empty);
        }
    }
}
