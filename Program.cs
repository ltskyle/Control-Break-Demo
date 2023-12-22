using Control_Break;

GameRating[] ratings = new GameRating[30];
Utility utility = new Utility(ratings);
Report report = new Report();

ratings = utility.GetAllRatings();

report.SortByGame(ratings);
report.RatingsByGame(ratings);
