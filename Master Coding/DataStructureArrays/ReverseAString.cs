using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureArrays
{
    public static class ReverseAString
    {
        ///A class to reverse a string
        public static string Reverse(string word)=> string.Join("", word.ToCharArray().Reverse());

    }
}
