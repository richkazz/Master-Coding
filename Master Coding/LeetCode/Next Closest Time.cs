using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Next_Closest_Time
    {
        public string NextClosestTime(string time)
        {
            var x = new DateTime(1, 1, 1, int.Parse(time.Split(":")[0]), int.Parse(time.Split(":")[1]), 0).Ticks;
            var c = new DateTime(1, 1, 2, 19, 33, 0).Ticks;
            int[] values = new int[4];
            values[0] = int.Parse(time.Split(":")[0].ToCharArray()[0].ToString());
            values[1] = int.Parse(time.Split(":")[0].ToCharArray()[1].ToString());
            values[2] = int.Parse(time.Split(":")[1].ToCharArray()[0].ToString());
            values[3] = int.Parse(time.Split(":")[1].ToCharArray()[1].ToString());
            var minute = time.Split(":")[0].ToCharArray();
            string hour = time.Split(":")[1];
            long min = x;
            List<string> possibleMinute = new List<string>();
            List<string> possibleHour = new List<string>();
            List<string> possibleMinute2 = new List<string>();
            List<string> possibleHour2 = new List<string>();
            List<string> possibleMinute3 = new List<string>();
            List<string> possibleHour3 = new List<string>();
            List<string> possibleMinute4 = new List<string>();
            List<string> possibleHour4 = new List<string>();
            
            for (int j = 0; j < 60; j++)
            {
                string i = j.ToString();
                if (i.Length == 1)
                {
                    i = "0" + i;
                }
                if (values[0] == values[2]|| values[0] == values[3])//first hour and first minute
                {
                    if(i.Substring(0,1)==values[0].ToString()&& i.Substring(1) == values[0].ToString())
                    {
                        possibleMinute.Add(i);
                    }



                }
                else
                {
                    if (((i.ToString().Contains(values[0].ToString()) && i.ToString().StartsWith(values[2].ToString()) && i.ToString().Length == 2)
                    || (i.ToString().Contains(values[0].ToString()) && i.ToString().EndsWith(values[3].ToString()) && i.ToString().Length == 2)
                    || (i.ToString().StartsWith(values[0].ToString()) && i.ToString().EndsWith(values[0].ToString()) && i.ToString().Length == 2)))

                    {
                        possibleMinute.Add(i);
                    }
                    if (j < 24)
                    {
                        if ((i.ToString().Contains(values[0].ToString()) && i.ToString().EndsWith(values[1].ToString()))
                                                                || (i.ToString().StartsWith(values[0].ToString()) && i.ToString().EndsWith(values[0].ToString()) && i.ToString().Length == 2))

                        {
                            possibleHour.Add(i);
                        }
                    }

                }
                
                if (values[1] == values[2]|| values[1] == values[3])
                {
                    if (i.Substring(0, 1) == values[1].ToString() && i.Substring(1) == values[1].ToString())
                    {
                        possibleMinute2.Add(i);
                    }
                    if (j < 24)
                    {
                        if ((i.ToString().Contains(values[1].ToString()) && i.ToString().StartsWith(values[0].ToString()))
                                        || (i.ToString().EndsWith(values[1].ToString()) && i.ToString().StartsWith(values[0].ToString()) && i.ToString().Length == 2))

                        {
                            possibleHour2.Add(i);
                        }

                    }
                }
                else
                {
                    if ((i.ToString().Contains(values[1].ToString()) && i.ToString().StartsWith(values[2].ToString()) && i.ToString().Length == 2)
                   || (i.ToString().Contains(values[1].ToString()) && i.ToString().EndsWith(values[3].ToString()) && i.ToString().Length == 2)
                   || (i.ToString().StartsWith(values[1].ToString()) && i.ToString().EndsWith(values[1].ToString()) && i.ToString().Length == 2))

                    {
                        possibleMinute2.Add(i);
                    }
                    if (j < 24)
                    {

                    }
                }
                if (values[2] == values[3])
                {
                    if (i.Substring(0, 1) == values[2].ToString() && i.Substring(1) == values[2].ToString())
                    {
                        possibleMinute3.Add(i);
                        possibleMinute4.Add(i);
                    }
                    
                }
                else
                {
                    if ((i.ToString().Contains(values[2].ToString()) && i.ToString().EndsWith(values[3].ToString()))
                                       || (i.ToString().StartsWith(values[2].ToString()) && i.ToString().EndsWith(values[2].ToString()) && i.ToString().Length == 2))

                    {
                        possibleMinute3.Add(i);
                    }
                    if ((i.ToString().Contains(values[3].ToString()) && i.ToString().StartsWith(values[2].ToString()))
                                            || (i.ToString().EndsWith(values[3].ToString()) && i.ToString().StartsWith(values[3].ToString()) && i.ToString().Length == 2))

                    {
                        possibleMinute4.Add(i);
                    }
                    if (j < 24)
                    {
                        if ((i.ToString().Contains(values[2].ToString()) && i.ToString().StartsWith(values[0].ToString()))
                  || (i.ToString().Contains(values[2].ToString()) && i.ToString().EndsWith(values[1].ToString()))
                  || (i.ToString().StartsWith(values[2].ToString()) && i.ToString().EndsWith(values[2].ToString()) && i.ToString().Length == 2))

                        {
                            possibleHour3.Add(i);
                        }
                        if ((i.ToString().Contains(values[3].ToString()) && i.ToString().StartsWith(values[0].ToString()))
                  || (i.ToString().Contains(values[3].ToString()) && i.ToString().EndsWith(values[1].ToString()))
                  || (i.ToString().StartsWith(values[3].ToString()) && i.ToString().EndsWith(values[3].ToString()) && i.ToString().Length == 2))

                        {
                            possibleHour4.Add(i);
                        }
                    }
                }
               
               
               
                if (j < 24)
                {
                    
                    
                   
                   
                }

            }
            
            //foreach (var num in values)
            //{
               
            //    //minute[1] = char.Parse(num.ToString());
            //    //if (int.Parse(minute[0].ToString()+ minute[1].ToString()) < 61)
            //    //{
            //    //    var d = new DateTime(1, 1, 1, 19, 39, 0).Ticks;
            //    //    min = Math.Max(min, d);
            //    //}
            //}
            return "";
        }
        long GetTickMinute(int minute, int orginalMinute)
        {
            var d = new DateTime(1, 1, 1, 19, 39, 0).Ticks;
            if (minute < orginalMinute)
            {
               
            }
            
            return d;
        }
    }
}
