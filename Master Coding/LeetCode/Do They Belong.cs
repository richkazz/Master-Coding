using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Do_They_Belong
    {
        public int doTheyBelong(int x1, int y1,int x2, int y2,int x3, int y3,int xp, int yp,int xq, int yq)
        {
            if (!isValidDegenerate(x1, y1, x2, y2, x3, y3))
                return 0;
            if (!isInside(x1, y1, x2, y2, x3, y3, xp, yp) && !isInside(x1, y1, x2, y2, x3, y3, xq, yq))
                return 4;

            if (isInside(x1, y1, x2, y2, x3, y3, xp, yp) && isInside(x1, y1, x2, y2, x3, y3, xq, yq))
                return 3;

            if (!isInside(x1, y1, x2, y2, x3, y3, xp, yp))
                return 2;

            if (!isInside(x1, y1, x2, y2, x3, y3, xq, yq))
                return 1;

            return 1;
        }

        bool isValidDegenerate(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double ab = Math.Abs(x2 - x1);
            double bc =Math.Abs( Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            double ac = Math.Abs(Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));

            if ((ab + bc > ac) && (bc + ac > ab) && (ab + ac > bc))
                return true;
            return false;
        }
        /* A utility function to calculate area of triangle
        formed by (x1, y1) (x2, y2) and (x3, y3) */
         double area(int x1, int y1, int x2,
                           int y2, int x3, int y3)
        {
            return Math.Abs((x1 * (y2 - y3) +
                             x2 * (y3 - y1) +
                             x3 * (y1 - y2)) / 2.0);
        }

        /* A function to check whether point P(x, y) lies
        inside the triangle formed by A(x1, y1),
        B(x2, y2) and C(x3, y3) */
         bool isInside(int x1, int y1, int x2,
                             int y2, int x3, int y3,
                             int x, int y)
        {
            /* Calculate area of triangle ABC */
            double A = area(x1, y1, x2, y2, x3, y3);

            /* Calculate area of triangle PBC */
            double A1 = area(x, y, x2, y2, x3, y3);

            /* Calculate area of triangle PAC */
            double A2 = area(x1, y1, x, y, x3, y3);

            /* Calculate area of triangle PAB */
            double A3 = area(x1, y1, x2, y2, x, y);

            /* Check if sum of A1, A2 and A3 is same as A */
            return (A == A1 + A2 + A3);
        }
    }
}
