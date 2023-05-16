using Data; // Allow program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
content.Title = "The SpongeBob Movie";
content.Description = "Shelby's favorite movie.";

Console.WriteLine(content.IsFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;
Console.WriteLine(content.IsFamilyFriendly);

StreamingContentRepository repository = new StreamingContentRepository();

List<StreamingContent> listBeforeAdd = repository.GetDirectory(); // <----

bool wasAdded = repository.AddContentToDirectory(content);
Console.WriteLine(wasAdded ? "The content was added" : "The content was not added");

List<StreamingContent> listAfterAdd = repository.GetDirectory(); // <----

Console.WriteLine(listBeforeAdd.Count);
Console.WriteLine(listAfterAdd.Count);

StreamingContent toystory = new StreamingContent("Toy Story", "Bromance", "A story about toys", 8.9, MaturityRating.G);
var rubber = new StreamingContent("Rubber", "Action/Thriller", "It's a tire", 7.5, MaturityRating.R);
repository.AddContentToDirectory(toystory);
repository.AddContentToDirectory(rubber);

List<string> titles = repository.GetTitles();
foreach (var title in titles)
{
    Console.WriteLine(title);
}

StreamingContent? foundContent = repository.GetContentByTitle("the spongebob movie");
// ?. only accesses the next part if not null
// (foundContent?.Title) will only access Title if foundContent is not null
Console.WriteLine(foundContent?.Title);
Console.WriteLine(foundContent?.Genre);
Console.WriteLine(foundContent?.Description);
Console.WriteLine(foundContent?.IsFamilyFriendly);

StreamingContent toyStory2 = new StreamingContent("Toy Story 2", "Bromance Part 2", "A story about toys", 7.5, MaturityRating.G);
repository.UpdateExistingContent("Toy Story", toyStory2);

foreach (var title in repository.GetTitles())
{
    Console.WriteLine(title);
}

// bool wasDeleted = repository.DeleteExistingContent(foundContent);
bool wasDeleted = repository.DeleteContentByTitle("toy story");

Console.WriteLine(wasDeleted ? "The content was deleted" : "The content was not deleted");