using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.LeetCode
{
    public class Dota2_Senate
    {
		public string PredictPartyVictory(string senate)
		{
			bool scanR = true;
			bool scanD = true;
			char[] cs = senate.ToArray();
			int person = 0;
			while (scanR && scanD)
			{
				scanR = false;
				scanD = false;
				for (int j = 0; j < cs.Length; j++)
				{
					if (cs[j] == 'R')
					{
						scanR = true;
						if (person < 0)
						{
							cs[j] = '*';
						}
						person += 1;
					}
					if (cs[j] == 'D')
					{
						scanD = true;
						if (person > 0)
						{
							cs[j] = '*';
						}
						person -= 1;
					}

				}
			}

			return person > 0 ? "Radiant" : "Dire";
		}
	}
}
