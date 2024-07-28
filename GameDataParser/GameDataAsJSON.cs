public class GameDataAsJSON {
    //"Title": "Stardew Valley",
    //"ReleaseYear": 2016,
    //"Rating": 4.9

    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }

    public GameDataAsJSON(string title, int releaseYear, double rating) {
        Title = title;
        ReleaseYear = releaseYear;
        Rating = rating;
    }
}