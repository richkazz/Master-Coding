using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class ComputeAreaClass
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {

            var l1 = Add(ax1, ax2);
            var b1 = Add(ay1, ay2);
            var a1 = l1 * b1;
            var l2 = Add(bx1, bx2);
            var b2 = Add(by1, by2);
            var a2 = l2 * b2;
            var overLalLen = LengthOverLap(ax1, ax2, bx1, bx2, "x");
            var overLalBre = LengthOverLap(ay1, ay2, by1, by2, "y");
            var a3 = overLalLen * overLalBre;
            Console.WriteLine(overLalBre);
            Console.WriteLine(overLalLen);
            if (overLalLen != 0 && overLalBre != 0)
            {
                return a1 + a2 - a3;
            }
            else if (ax1 == bx1 && ax2 == bx2 && ay1 == by1 && ay2 == by2)
            {
                return a1;
            }
            else
            {
                return a1 + a2;
            }



            return overLalLen;
        }
        public int  ComputeArea1(long A, long B, long C, long D, long E, long F, long G, long H)
        {
            long x = Math.Max(A, E) < Math.Min(C, G) ? (Math.Min(C, G) - Math.Max(A, E)) : 0;
            long y = Math.Max(B, F) < Math.Min(D, H) ? (Math.Min(D, H) - Math.Max(B, F)) : 0;
            return (int)((C - A) * (D - B) + (G - E) * (H - F) - x * y);
        }
        int LengthOverLap(int ax1, int ax2, int bx1, int bx2, string axis)
        {
            var overLalLen = 0;
            if ((ax1 < bx1 && ax2 > bx1) && (ax1 < bx2 && ax2 > bx2))
            {
                return Add(bx1, bx2);
            }
            else if ((bx1 < ax1 && bx2 > ax1) && (bx1 < ax2 && bx2 > ax2))
            {
                return Add(ax1, ax2);
            }
            else if (ax1 <= bx1 && ax2 >= bx1 && !(ax1 <= bx2))
            {
                if (bx2 >= ax2)
                {
                    overLalLen = Math.Abs(ax2 - bx1);
                }
                else
                {
                    overLalLen = Math.Abs(ax1 - bx1);
                }
            }
            else if (ax1 <= bx2 && ax2 >= bx2)
            {
                if (bx1 <= ax1)
                {
                    overLalLen = Math.Abs(ax1 - bx2);
                }
                else
                {
                    overLalLen = Math.Abs(ax2 - bx2);
                }
            }
            return overLalLen;
        }


        int Add(int num1, int num2) => Math.Abs(num1 - num2);

    }
}
