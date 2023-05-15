// // bool is a true false value, with no quotes
// bool isAwake = true;
// Console.WriteLine(isAwake);

// // Integers, or int, are whole numbers
// int age = 42;
// Console.WriteLine(age);

// // Double is a decimal type (32bit)
// double notAWholeNumber = 42.5;
// double withASuffix = 37.1d;
// Console.WriteLine(notAWholeNumber + withASuffix);

// // Float is also a decimal type (16bit)
// float anotherDecimal = 3.14f;
// Console.WriteLine(anotherDecimal);

// // Decimal is a very precise decimal (64bit)
// decimal aLargeDecimal = 8.333333333333m;
// Console.WriteLine(aLargeDecimal);

// // 3.1415926535897932384626433832795028841971
// Console.WriteLine("Float: " + 3.1415926535897932384626433832795028841971f);
// Console.WriteLine("Double: " + 3.1415926535897932384626433832795028841971d);
// Console.WriteLine("Decimal: " + 3.1415926535897932384626433832795028841971m);

// // Strings (collections of characters)
// // Strings in C# use double quotes
// string myName = "Joshua";
// Console.WriteLine(myName);

// // Characters (char)
// // Single character, number, symbol, etc.
// // Characters use single quotes
// char mander = '4';
// char space = ' ';
// char symbol = '@';
// char escapeCharacter = '\n';
// Console.WriteLine(mander + space + symbol + escapeCharacter);


// Reference Types
// Variables that hold a reference rather than a value

// Array type[]
// Collection of similarly typed items (strings here)
string[] ourClass = {
    "Braulio",
    "Brianne",
    "Edwin",
    "Garrett",
    "Isaac",
    "Jackson",
    "Marla",
    "Shelby"
};

Console.WriteLine(ourClass.Length);

string[] sd167 = ourClass;

Console.WriteLine(sd167.Length);

// Read from an array index
Console.WriteLine(sd167[5]);

// Write to an array index
sd167[5] = "Jackson Lee";

Console.WriteLine(ourClass[5]);
Console.WriteLine(sd167[5]);

Bed myBed = new Bed();
myBed.NumberOfPillows = 2;
myBed.Color = "Gray";

// Assigns the reference that myBed holds to the variable thisBed
Bed thisBed = myBed;

Console.WriteLine(thisBed.Color);

myBed.Color = "Blue";

Console.WriteLine(thisBed.Color);

Console.WriteLine(myBed == thisBed);

thisBed = new Bed();
thisBed.Color = "Blue";
thisBed.NumberOfPillows = 2;

Console.WriteLine($"A {thisBed.Color} bed with {thisBed.NumberOfPillows} pillows.");
Console.WriteLine($"A {myBed.Color} bed with {myBed.NumberOfPillows} pillows.");

Console.WriteLine(myBed.Color == thisBed.Color);

// Lists
// An expandable collection in C# (like a javascript array)

// Declare a list
List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();

// Add to lists
listOfStrings.Add("First string for our list.");
listOfIntegers.Add(46307);

for (int i = 0; i < 1000; i++)
{
    listOfIntegers.Add(i);
}

// Get values from the list
string firstString = listOfStrings[0];

// assign a value to an index
listOfIntegers[0] = 219;

// Remove from a list
listOfStrings.Remove("First string for our list.");

listOfIntegers.RemoveAt(0);
listOfIntegers.RemoveRange(60, 200);
listOfIntegers.RemoveAll(number => number % 2 == 0);

foreach (int num in listOfIntegers)
{
    Console.Write(num + ", ");
}


// Queues
// Like a list but order matters
// First In First Out manner (FIFO)
Queue<string> firstInFirstOutCollection = new Queue<string>();

// Add to a queue (Enqueue)
firstInFirstOutCollection.Enqueue("I'm first!");
firstInFirstOutCollection.Enqueue("I'm next!");

// Peek at the front of the queue without changing the queue
string first = firstInFirstOutCollection.Peek();
Console.WriteLine(first);
Console.WriteLine(firstInFirstOutCollection.Count);

// Remove an item from the front of the queue
string removedItem = firstInFirstOutCollection.Dequeue();
Console.WriteLine(firstInFirstOutCollection.Count);


// Stack
// Stack is the opposite of a queue
// First In Last Out (Last in First Out)
Stack<string> lastInFirstOut = new Stack<string>();
lastInFirstOut.Push("Add to the stack");
lastInFirstOut.Pop(); // Remove from the stack


// Dictionary
// Key Value pair collections
// Dictionary<KeyType, ValueType> name = new Dictionary<KeyType, ValueType>();
Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(7, "Agent");
keyAndValue.Add(219, "Another string");

string valueSeven = keyAndValue[7];
keyAndValue[7] = "Any string we want to pass in";
Console.WriteLine(valueSeven);

Dictionary<string, Bed> beds = new Dictionary<string, Bed>();
beds.Add("mine", myBed);
beds.Add("that one", thisBed);

string? myBedColor = beds["mine"].Color;
Console.WriteLine(myBedColor);



// DateTime type
DateTime birthday = new DateTime(1972, 6, 20);
DateTime todayDate = DateTime.Today;
DateTime nowTime = DateTime.Now;

TimeSpan age = nowTime - birthday;
Console.WriteLine(age.TotalDays / 365.25);


// Enums
// A basic type that has a set number of values
// Associated via a theme of some sort
// Examples might be days of the week, months of the year, hours of the day

WeekDays day = WeekDays.Wednesday;
if (day == WeekDays.Saturday)
{
    Console.WriteLine("Yay!");
}

switch (day) 
{
    case WeekDays.Monday:
        break;
    case WeekDays.Tuesday:
        break;
    case WeekDays.Wednesday:
        break;
    case WeekDays.Thursday:
        break;
    case WeekDays.Friday:
        break;
    case WeekDays.Saturday:
        break;
    case WeekDays.Sunday:
        break;
}

enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
enum Months { Jan = 1, Feb, Mar, Apr, Dec = 12 }

class Bed
{
    public int NumberOfPillows { get; set; }
    public string? Color { get; set; }
}
