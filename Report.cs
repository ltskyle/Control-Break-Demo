using Control_Break;

namespace Control_Break
{
    public class Report
    {
        public Report()
        {
        }
        
        public void SortByGame(GameRating[] ratings)
        {
            for (int i = 0; i < GameRating.GetCount() - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < GameRating.GetCount(); j++)
                {
                    if (ratings[j].GetGameTitle().CompareTo(ratings[min].GetGameTitle()) < 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    Swap(ratings, min, i);
                }
            }
        }

        public void Swap(GameRating[] ratings, int x, int y)
        {
            GameRating temp = ratings[x];
            ratings[x] = ratings[y];
            ratings[y] = temp;
        }

        public void RatingsByGame(GameRating[] ratings)
        {
            string curr = ratings[0].GetGameTitle();
            int ratingTotal = ratings[0].GetRating();
            int gameTitleCount = 1;

            System.Console.WriteLine("Average rating per game:\n");

            for (int i = 1; i < GameRating.GetCount(); i++)
            {
                if (curr == ratings[i].GetGameTitle())
                {
                    ratingTotal += ratings[i].GetRating();
                    gameTitleCount++;
                }
                else
                {
                    ProcessBreak(ref curr, ref gameTitleCount, ref ratingTotal, ratings, i);
                }
            }
            ProcessBreak(ref curr, ref gameTitleCount, ref ratingTotal, ratings, ratings.Length);
        }

        private void ProcessBreak(ref string curr, ref int gameTitleCount, ref int ratingTotal, GameRating[] ratings, int i)
        {
            double avgRating = (double)ratingTotal / gameTitleCount;
            System.Console.WriteLine($"{curr}: {avgRating}");

            if (i < ratings.Length)
            {
                curr = ratings[i].GetGameTitle();
                ratingTotal = ratings[i].GetRating();
                gameTitleCount = 1;
            }
        }
    }
}
