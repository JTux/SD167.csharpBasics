// Plain Old C# Object (POCO)
// This just represents the data object
// Properties, not methods

namespace Data;

public class StreamingContent
{
    public StreamingContent()
    {
        MaturityRating = MaturityRating.Unrated;
    }
    public StreamingContent(string title, string genre, string description, double score, MaturityRating rating)
    {
        // Property = parameter;
        Title = title;
        Genre = genre;
        Description = description;
        UserScore = score;
        MaturityRating = rating;
    }

    public string? Title { get; set; }
    public string? Genre { get; set; }
    public string? Description { get; set; }
    public double UserScore { get; set; }
    public MaturityRating MaturityRating { get; set; }
    public bool IsFamilyFriendly
    {
        get
        {
            switch (MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                case MaturityRating.PG_13:
                case MaturityRating.R:
                case MaturityRating.NC_17:
                case MaturityRating.TV_14:
                case MaturityRating.TV_MA:
                default:
                    return false;
            }
        }
    }
}

public enum MaturityRating
{
    G,
    PG,
    PG_13,
    R,
    NC_17,
    TV_Y,
    TV_G,
    TV_PG,
    TV_14,
    TV_MA,
    Unrated
}
