using Control_Break;

namespace Control_Break
{
    public class Utility
    {
        private GameRating[] ratings;

        public Utility(GameRating[] ratings)
        {
            this.ratings = ratings;
        }

        public GameRating[] GetAllRatings()
        {
            StreamReader inFile = new StreamReader("mario_adventure_log.txt");
            string line = inFile.ReadLine();
            GameRating.SetCount(0);

            while (line != null)
            {
                string[] temp = line.Split("#");

                this.ratings[GameRating.GetCount()] = new GameRating(temp[0], temp[1], temp[2], int.Parse(temp[3]));
                GameRating.IncCount();

                line = inFile.ReadLine();
            }

            inFile.Close();
            return ratings;
        }
    }
}
