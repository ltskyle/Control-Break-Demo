using Control_Break;

namespace Control_Break
{
    public class GameRating
    {
        private string gameTitle;
        private string levelName;
        private string charactersEncountered;
        private int rating;
        static private int count;

        public GameRating()
        {

        }

        public GameRating(string gameTitle, string levelName, string charactersEncountered, int rating)
        {
            this.gameTitle = gameTitle;
            this.levelName = levelName;
            this.charactersEncountered = charactersEncountered;
            this.rating = rating;
        }

        public void SetGameTitle(string gameTitle)
        {
            this.gameTitle = gameTitle;
        }
        public string GetGameTitle()
        {
            return gameTitle;
        }
        public void SetLevelName(string levelName)
        {
            this.levelName = levelName;
        }
        public string GetLevelName()
        {
            return levelName;
        }
        public void SetCharactersEncountered(string charactersEncountered)
        {
            this.charactersEncountered = charactersEncountered;
        }
        public string GetCharactersEncountered()
        {
            return charactersEncountered;
        }
        public void SetRating(int rating)
        {
            this.rating = rating;
        }
        public int GetRating()
        {
            return rating;
        }

        public static void SetCount(int newCount)
        {
            count = newCount;
        }
        public static int GetCount()
        {
            return count;
        }
        public static void IncCount()
        {
            count++;
        }

        public override string ToString()
        {
            return $"{gameTitle}\t{levelName}\t{charactersEncountered}\t{rating}";
        }
    }
}