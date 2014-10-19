using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5FindMissingNumberInArray
{
    class FindMissingNumber
    {
        string[] str;

        public FindMissingNumber(string p)
        {
            str = p.Split(',');
        }

        public int getMissingNumber()
        {
            int pos=99999;
            int temp;
            for (int i = 0; i < str.Length; i++ )
            {
                if (!int.TryParse(str[i],out temp))// || str[i] == "")
                {
                    pos = i;
                }
            }
            return pos;
        }
    }
}
