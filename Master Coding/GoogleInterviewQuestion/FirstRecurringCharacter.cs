using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.GoogleInterviewQuestion
{
    public static class FirstRecurringCharacter
    {
        //Google Question
        //Given an array = [2,5,1,2,3,5,1,2,4]:
        //It should return 2

        //Given an array = [2,1,1,2,3,5,1,2,4]:
        //It should return 1

        //Given an array = [2,3,4,5]:
        //It should return undefined


        public static dynamic FirstRecurringCharacterFunction(int[] input)
        {
            //Bonus... What if we had this:
            // [2,5,5,2,3,5,1,2,4]
            // return 5 because the pairs are before 2,2
            if (!input.Any())
            {
                return "undefined";
            }
            Dictionary<int, bool> keepCharacter = new Dictionary<int, bool>();
            foreach(var character in input)
            {
                if (!keepCharacter.ContainsKey(character))
                {
                    keepCharacter.Add(character, true);
                }
                else
                {
                    return character;
                }
            }
            return "undefined";
        }

    }
}
