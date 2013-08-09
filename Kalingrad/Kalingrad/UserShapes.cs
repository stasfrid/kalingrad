using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Kalingrad
{
    public static class UserShapes
    {
        public static RightShape createDiamond()
        {

            // set up the points
            Vector2[] rightPoints = new Vector2[6];

            // set point
            rightPoints[0] = new Vector2((Game1.WIDTH / 2) + 120, (Game1.HEIGHT / 2) - 100);
            rightPoints[1] = new Vector2((Game1.WIDTH / 2) + 170, (Game1.HEIGHT / 2) - 160);
            rightPoints[2] = new Vector2((Game1.WIDTH / 2) + 230, (Game1.HEIGHT / 2) - 160);
            rightPoints[3] = new Vector2((Game1.WIDTH / 2) + 280, (Game1.HEIGHT / 2) - 100);
            rightPoints[4] = new Vector2((Game1.WIDTH / 2) + 200, (Game1.HEIGHT / 2));
            rightPoints[5] = new Vector2((Game1.WIDTH / 2) + 200, (Game1.HEIGHT / 2) - 80);


            // edges 
            List<Point> edges = new List<Point>();

            // rectangle
            for (int i = 0; i < 4; i++)
            {
                edges.Add(new Point(i, i + 1));
            }

            edges.Add(new Point(4, 0));

            edges.Add(new Point(0, 2));
            edges.Add(new Point(0, 5));
            edges.Add(new Point(1, 5));
            edges.Add(new Point(1, 3));
            edges.Add(new Point(2, 5));
            edges.Add(new Point(3, 5));

            return (new RightShape(new List<Vector2>(rightPoints), edges));

        }

        public static RightShape createPent()
        {

            // set up the points
            Vector2[] rightPoints = new Vector2[5];

            // set point
            rightPoints[0] = new Vector2((Game1.WIDTH / 2) + 120, (Game1.HEIGHT / 2) - 100);
            rightPoints[2] = new Vector2((Game1.WIDTH / 2) + 280, (Game1.HEIGHT / 2) - 100);
            rightPoints[4] = new Vector2((Game1.WIDTH / 2) + 150, (Game1.HEIGHT / 2));
            rightPoints[3] = new Vector2((Game1.WIDTH / 2) + 250, (Game1.HEIGHT / 2));
            rightPoints[1] = new Vector2((Game1.WIDTH / 2) + 200, (Game1.HEIGHT / 2) - 180);


            // edges 
            List<Point> edges = new List<Point>();

            // rectangle
            for (int i = 0; i < 4; i++)
            {
                edges.Add(new Point(i, i + 1));
            }

            edges.Add(new Point(4, 0));

            // diagonals
            edges.Add(new Point(1, 3));
            edges.Add(new Point(1, 4));
            edges.Add(new Point(0, 2));
            edges.Add(new Point(0, 3));
            edges.Add(new Point(2, 4));

            return (new RightShape(new List<Vector2>(rightPoints), edges));

        }

        public static RightShape createRect()
        {
            // set up the points
            Vector2[] rightPoints = new Vector2[4];

            // set point
            rightPoints[0] = new Vector2((Game1.WIDTH / 2) + 150, (Game1.HEIGHT / 2) - 100);
            rightPoints[1] = new Vector2((Game1.WIDTH / 2) + 250, (Game1.HEIGHT / 2) - 100);
            rightPoints[3] = new Vector2((Game1.WIDTH / 2) + 150, (Game1.HEIGHT / 2));
            rightPoints[2] = new Vector2((Game1.WIDTH / 2) + 250, (Game1.HEIGHT / 2));

            // edges 
            List<Point> edges = new List<Point>();

            // rectangle
            for (int i = 0; i < 3; i++)
            {
                edges.Add(new Point(i, i + 1));
            }

            edges.Add(new Point(3, 0));


            return (new RightShape(new List<Vector2>(rightPoints), edges));
        }

        public static RightShape createHouseShape()
        {

            // set up the points
            Vector2[] rightPoints = new Vector2[5];

            // set point
            rightPoints[0] = new Vector2((Game1.WIDTH / 2) + 150, (Game1.HEIGHT / 2) - 100);
            rightPoints[1] = new Vector2((Game1.WIDTH / 2) + 250, (Game1.HEIGHT / 2) - 100);
            rightPoints[3] = new Vector2((Game1.WIDTH / 2) + 150, (Game1.HEIGHT / 2));
            rightPoints[2] = new Vector2((Game1.WIDTH / 2) + 250, (Game1.HEIGHT / 2));
            rightPoints[4] = new Vector2((Game1.WIDTH / 2) + 200, (Game1.HEIGHT / 2) - 150);


            // edges 
            List<Point> edges = new List<Point>();

            // rectangle
            for (int i = 0; i < 3; i++)
            {
                edges.Add(new Point(i, i + 1));
            }

            edges.Add(new Point(3, 0));

            // diagonals
            edges.Add(new Point(0, 2));
            edges.Add(new Point(1, 3));
            // house top
            edges.Add(new Point(0, 4));
            edges.Add(new Point(1, 4));

            return (new RightShape(new List<Vector2>(rightPoints), edges));
        }

    }
}
