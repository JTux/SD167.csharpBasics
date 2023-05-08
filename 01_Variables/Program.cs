// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Command Palette:
// Windows: ctrl + shift + p
// Mac: cmd + shift + p

// > OmniSharp: Restart OmniSharp

// Declaring Variables
// JavaScript: let name = "value"

// C#: type name = "value";
string firstName = "Charlie";

// 1. The type is string
// 2. The variable name is firstName
// 3. = is the assignment operator
// 4. The value is "Charlie"

// ctrl + . is our quick fix shortcut

Console.WriteLine(firstName);
// Can change the value, not the type
firstName = "Scott";
Console.WriteLine(firstName);

// Prompt the user for input
Console.WriteLine("What is your favorite color?");

// Capture the user's input/response
// ? indicates that the type is nullable (can be null)
string? color = Console.ReadLine();
Console.WriteLine("You said your favorite color is " + color);
