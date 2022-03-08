using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Maximum_XOR_of_Two_Numbers_in_an_Array
    {
        public int FindMaximumXOR(int[] nums)
        {

            int i = 0;
            int j = 0;
            int max = int.MinValue;
            var x =  nums.ToList();
            x.Sort();
            while (i < nums.Length)
            {
                j = i;
                while (j < nums.Length)
                {

                    max = Math.Max(GetXORofTwoInt(nums[i], nums[j]), max);
                    if (max == 127)
                    {

                    }
                    j++;
                }
                
                i++;
               
            }
            return max;
        }

        int GetXORofTwoInt(int num1, int num2)
        {
            var binaryNum1 = Convert.ToString(num1, 2).ToArray();
            var binaryNum2 = Convert.ToString(num2, 2).ToArray();
            int i = binaryNum1.Length - 1;
            int j = binaryNum2.Length - 1;
            var result = 0;
            if (i >= j)
            {
                result = Convert.ToInt32(XOR(binaryNum1, binaryNum2, i, j), 2);
            }
            else
            {
                result = Convert.ToInt32(XOR(binaryNum2, binaryNum1, j, i), 2);
            }
            return result;
        }
        string XOR(char[] bigArray, char[] smallArray, int big, int small)
        {
            int i = small;
            char[] result = new char[big + 1];
            while (big >= 0)
            {
                if (small >= 0)
                {
                    if (bigArray[big] == '1' && smallArray[small] == '1')
                    {
                        result[big] = '0';
                    }
                    else if (bigArray[big] == '0' && smallArray[small] == '0')
                    {
                        result[big] = '0';
                    }
                    else
                    {
                        result[big] = '1';
                    }
                }
                else
                {
                    result[big] = bigArray[big];
                }
                big--;
                small--;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(result);
            return sb.ToString();
        }
    }
}
