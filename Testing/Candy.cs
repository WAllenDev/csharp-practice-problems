using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Candy
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> candyKing = new List<bool>();
            int mostCandy = 0;

            for( int i=0; i<candies.Length; i++)
            {
                if (candies[i] > mostCandy)
                {
                    mostCandy = candies[i];
                }
            }

            for( int i=0; i<candies.Length; i++)
            {
                if(candies[i]+extraCandies >= mostCandy)
                {
                    candyKing.Add(true);
                } else
                {
                    candyKing.Add(false);
                }
            }

            return candyKing;
        }
    }
}
