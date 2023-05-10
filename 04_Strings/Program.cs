string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

string space = " ";

// Concatenation (using the + operator)
string concatenatedResult = first + space + second;

Console.WriteLine(concatenatedResult);

// Composite Formatting (uses {} and indexes)
string firstName = "Joshua";
string lastName = "Tucker";

string compositeResult = string.Format("My name is {0} {1}.", firstName, lastName);
Console.WriteLine(compositeResult);

Console.WriteLine("The name is {1}. {0} {2} {1}.", firstName, lastName, "Middle Name");


// String Interpolation (The one with the $)
string interpolationResult = $"My name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult);