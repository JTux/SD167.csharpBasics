using Data; // Allow program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
content.Title = "The SpongeBob Movie";

Console.WriteLine(content.IsFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;
Console.WriteLine(content.IsFamilyFriendly);

StreamingContentRepository repository = new StreamingContentRepository();

bool wasAdded = repository.AddContentToDirectory(content);
Console.WriteLine(wasAdded ? "The content was added" : "The content was not added");

