/*
- Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.

- Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".

Bonus: After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).

Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'.
*/

string word = "Supercalifragilisticexpialidocious";

// foreach (type iterator in collection)
foreach (char letter in word)
{
    // Console.WriteLine(letter);
    if (letter == 'i')
    {
        Console.WriteLine(letter);
    }
    else if (letter == 'l')
    {
        Console.WriteLine(letter);
    }
    else
    {
        Console.WriteLine("Not an i or l.");
    }

    switch (letter)
    {
        case 'i':
        case 'l':
            Console.WriteLine(letter);
            break;
        default:
            Console.WriteLine("Not an i or l.");
            break;
    }
}

Console.WriteLine(word.Length);
//   iterator ; condition      ; what happens after each iteration
for (int i = 0; i < word.Length; i++)
{
    // get the character at the index of i in word
    char letter = word[i];

    // string output = (letter == 'i' || letter == 'l') ? letter.ToString() : "Not an i or l.";
    string output = (letter == 'i' || letter == 'l') // condition 
        ? letter.ToString() // what to return for true
        : "Not an i or l."; // what to return for false

    Console.WriteLine(output);
}