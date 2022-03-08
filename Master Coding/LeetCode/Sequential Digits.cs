using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Sequential_Digits
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var result = new List<int>();
            var current = low.ToString().ToArray();
            var digit = GetSequence(current);
            if (digit< low)
            {
                current[0] =char.Parse( (int.Parse(current[0].ToString()) + 1).ToString());
                digit = GetSequence(current);
                current = digit.ToString().ToArray();
                if (digit > high||digit==0)
                    return result;
                result.Add(digit);
                current[0] = char.Parse((int.Parse(current[0].ToString()) + 1).ToString());
                digit = GetSequence(current);
                if (digit > high || digit == 0)
                    return result;
            }
            
            while(digit <= high)
            {
                result.Add(digit);
                current = digit.ToString().ToArray();
                current[0] = char.Parse((int.Parse(current[0].ToString()) + 1).ToString());
                digit = GetSequence(current);
                if (digit == 0)
                    break;
            }
            return result;
        }
      
        public int GetSequence(char[] array)
        {
            var x = 0;
            int first = int.Parse(array[0].ToString());
            var result = new StringBuilder();
            result.Append(first.ToString());
            for (int i = 1; i < array.Length; i++)
            {
                if (first + 1 == 10)
                {
                    array = new char[array.Length + 1];
                    array[0] = char.Parse(1.ToString());
                    if (array.Length == 10)
                        return 0;
                    return GetSequence(array);
                    
                }
               
                array[i] = char.Parse((++first).ToString());
                result.Append(first.ToString());
            }
            return int.Parse(result.ToString());
        }
    }
}
