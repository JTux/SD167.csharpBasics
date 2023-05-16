// Turn the file into C#
string fileContent = File.ReadAllText("./game-sequence.txt");
Console.WriteLine(fileContent);

// Turn the C# string into an array (so we can iterate over it)
string[] encounters = fileContent.Split(",");
Console.WriteLine(encounters);

// Declare the starting values
int points = 5000;
int lives = 4;
int vbhCount = 0; // vulnerable bird hunters
bool extraLife = false;
// int extraLives = 0;

// Iterate over each interaction/encounter/bird
foreach (string encounter in encounters)
{
    Console.WriteLine(encounter);
    // Switch Expression
    int pointsToAdd = encounter switch
    {
        // caseValue => returnValue
        "Bird" => 10,
        "CrestedIbis" => 100,
        "GreatKiskudee" => 300,
        "RedCrossbill" => 500,
        "Red-neckedPhalarope" => 700,
        "EveningGrosbeak" => 1000,
        "GreaterPrairieChicken" => 2000,
        "IcelandGull" => 3000,
        "Orange-belliedParrot" => 5000,
        _ => 0 // default
    };

    points += pointsToAdd; // points = points + pointsToAdd;

    // Calculate Vulnerable Bird Hunter points
    if (encounter == "VulnerableBirdHunter")
    {
        int vbhPoints = vbhCount switch
        {
            0 => 200,
            1 => 400,
            2 => 800,
            3 => 1600,
            _ => 0
        };

        points += vbhPoints;
        vbhCount++;
        Console.WriteLine($"You have found {vbhCount} Vulnerable Bird Hunters.");
    }

    // Get a bonus life at 10000 points
    if (points >= 10000 && extraLife == false)
    // if (points / 10000 > extraLives)
    {
        lives++;
        extraLife = true;
        // extraLives++;
    }

    // Invulnerable Bird Hunters
    if (encounter == "InvincibleBirdHunter")
    {
        lives--;

        // If you die end the loop
        if (lives == 0) // lives < 1
        {
            break;
        }
    }
}

// Each encounter calculate points, life, death

Console.WriteLine(points);
Console.WriteLine(lives);