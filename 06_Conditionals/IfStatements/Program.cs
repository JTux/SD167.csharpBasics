bool isRaining = true;
bool isGoingOutside = false;

/*
If Statement Syntax
if (true/false value or expression)
{
    Curly braces on a new line

    Body of code to be executed if the condition is true
}
*/

if (isRaining)
{
    Console.WriteLine("It is raining.");
}

// If is raining AND we are going outside
if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an umbrella.");
}

// Is not raining OR We are not going outside
if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively raining or we are going outside
if (isRaining ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside if it is not raining.");
}

// If it is not raining cut the grass, if it is raining don't cut the grass
if (isRaining) // True
{
    // ...
}

if (!isRaining) // False
{
    // ...
}

if (!isRaining)
{
    Console.WriteLine("I will go cut the grass.");
}
else
{
    Console.WriteLine("I will not cut the grass.");
}

Console.WriteLine("How are you feeling on a scale of 1-5?");
string? rating = Console.ReadLine();
