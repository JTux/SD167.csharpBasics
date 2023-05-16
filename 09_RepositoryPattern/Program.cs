using Data; // Allow program.cs to access the namespace Data

StreamingContent content = new StreamingContent();
Console.WriteLine(content.IsFamilyFriendly);
Console.WriteLine(content.MaturityRating);

content.MaturityRating = MaturityRating.TV_Y;
Console.WriteLine(content.IsFamilyFriendly);
