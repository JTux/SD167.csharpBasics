// bool is a true false value, with no quotes
bool isAwake = true;
Console.WriteLine(isAwake);

// Integers, or int, are whole numbers
int age = 42;
Console.WriteLine(age);

// Double is a decimal type (32bit)
double notAWholeNumber = 42.5;
double withASuffix = 37.1d;
Console.WriteLine(notAWholeNumber + withASuffix);

// Float is also a decimal type (16bit)
float anotherDecimal = 3.14f;
Console.WriteLine(anotherDecimal);

// Decimal is a very precise decimal (64bit)
decimal aLargeDecimal = 8.333333333333m;
Console.WriteLine(aLargeDecimal);

// 3.1415926535897932384626433832795028841971
Console.WriteLine("Float: " + 3.1415926535897932384626433832795028841971f);
Console.WriteLine("Double: " + 3.1415926535897932384626433832795028841971d);
Console.WriteLine("Decimal: " + 3.1415926535897932384626433832795028841971m);

// Strings (collections of characters)
// Strings in C# use double quotes
string myName = "Joshua";
Console.WriteLine(myName);

// Characters (char)
// Single character, number, symbol, etc.
// Characters use single quotes
char mander = '4';
char space = ' ';
char symbol = '@';
char escapeCharacter = '\n';
Console.WriteLine(mander + space + symbol + escapeCharacter);