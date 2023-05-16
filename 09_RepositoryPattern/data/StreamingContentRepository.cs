namespace Data;

public class StreamingContentRepository
{
    // Field that acts as our "Database" connection
    // readonly because we don't our collection reference to change
    private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    // Create
    // Add to our list, or CREATE a new data entry
    public bool AddContentToDirectory(StreamingContent content)
    {
        // Check the state of the current directory
        int startingCount = _contentDirectory.Count;

        // Try to add the new content to the directory
        if (content.Title != null)
        {
            _contentDirectory.Add(content);
        }

        // Check to see that it worked and was added
        bool countIncreased = _contentDirectory.Count > startingCount;

        // Return a true/false based on the result
        return countIncreased;
    }

    // Read
    public List<string> GetTitles()
    {
        // Declare a list to store the titles
        List<string> titles = new List<string>();

        // Add each title to that list
        foreach (StreamingContent content in _contentDirectory)
        {
            // Add the title property to the list unless it's null
            // If it's null, add "Untitled" to the list
            titles.Add(content.Title ?? "Untitled");
        }

        // Return our new list
        return titles;

        // Does the same thing that the above code does
        // .Select is the C# equivalent of JS .map
        // return _contentDirectory.Select(content => content.Title ?? "Untitled").ToList();
    }

    public List<StreamingContent> GetDirectory()
    {
        // // Returns a reference to the readonly list
        // return _contentDirectory;

        // Creates a new List with the same content
        // Returns a reference to the new list
        return new List<StreamingContent>(_contentDirectory);
    }

    public StreamingContent? GetContentByTitle(string title)
    {
        // Loop through each streaming content instance in the directory
        foreach (StreamingContent sc in _contentDirectory)
        {
            // Check that the title of sc (iterator) equals the title parameter
            if (sc.Title?.ToLower() == title.ToLower())
            {
                // If the titles match, return sc
                return sc;
            }
        }

        // If we've looped through the entire directory and not found the title
        return null;
    }

    // Update
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        // Get the old content and verify it exists
        StreamingContent? oldContent = GetContentByTitle(originalTitle);

        if (oldContent == null) 
        {
            // If oldContent was not found, we return false
            return false;
        }

        // oldContent was found and is not null

        // Only need option 1 or option 2, not both:

        // 1) Replace values for all properties
        // The reference never changes
        oldContent.Title = newContent.Title;
        oldContent.Genre = newContent.Genre;
        oldContent.Description = newContent.Description;
        oldContent.MaturityRating = newContent.MaturityRating;
        oldContent.UserScore = newContent.UserScore;
        
        // 2) Replace the reference held in the List
        // Swap one stored reference for another
        int index = _contentDirectory.IndexOf(oldContent);
        _contentDirectory[index] = newContent;

        return true;
    }

    // Delete
    // Remove existing content from our directory
    public bool DeleteExistingContent(StreamingContent existingContent)
    {
        if (existingContent.UserScore > 9)
        {
            return false;
        }

        bool deleteResult = _contentDirectory.Remove(existingContent);
        return deleteResult;
    }

    public bool DeleteContentByTitle(string title)
    {
        StreamingContent? targetContent = GetContentByTitle(title);
        if (targetContent == null)
        {
            return false;
        }

        bool deleteResult = DeleteExistingContent(targetContent);
        return deleteResult;
    }

}