/*
Class Creation w/ Property
- Create a User class
- Give the user a FirstName, LastName, ID (an integer, with no setter), and BirthDate properties.
- Create constructor for this class that has parameters for all the necessary properties.

Bonus: Create a method that returns the full name of the user.

Double Bonus: Create a method that returns the age of the user in years.
*/
using UserClassChallenge;

User user1 = new User(1, "Josh", "Tucker");
user1.MiddleName = "Middle Name";

Birthday bday = new Birthday(5, 12, 1980);
user1.Birthday = bday;
// User user1 = new User(id: 1, firstName: "Josh", lastName: "Tucker");
// user1.Birthday = new Birthday(5, 12, 1980);

DescribeUser(user1); // invoking the DescriberUser function

int userCounter = 2;

// Ask the user for the firstName
Console.WriteLine("What is your first name?");
string firstName = Console.ReadLine() ?? "User";

// Ask the user for the lastName
Console.Write("Enter your last name: ");
string lastName = Console.ReadLine() ?? userCounter.ToString();

// Created a user instance called consoleUser
User consoleUser = new User(userCounter, firstName, lastName);

DescribeUser(consoleUser);

// Top level function
// void is the return type
void DescribeUser(User user)
{
    // string description = $"User #{user.ID} is {user.FirstName} {user.LastName}";
    string description = $"User #{user.ID} is {user.Name}";
    Console.WriteLine(description);
    Console.WriteLine($"Their full name is {user.GetFullName()}");
}

namespace UserClassChallenge
{
    class User
    {
        // Constructor
        public User(int id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Properties
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public int ID { get; } // Readonly property
        // Day, Month, and a Year property
        public Birthday? Birthday { get; set; }

        public string Name
        {
            get
            {
                // string concatenation
                string fullName = FirstName + " " + LastName;
                return fullName;
            }
        }

        // Methods
        public string GetFullName()
        {
            // string array
            string?[] names = { FirstName, MiddleName, LastName };

            // string fullName = $"{FirstName} {MiddleName} {LastName}";
            string fullName = string.Join(" ", names.OfType<string>());
            return fullName;
        }
    }

    class Birthday
    {
        // Constructor
        public Birthday(int month, int day, int year)
        {
            // property = parameter;
            Month = month;
            Day = day;
            Year = year;
        }

        // Properties
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
    }
}