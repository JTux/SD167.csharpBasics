/*
Create a Calculator class that has the ability to complete all of the following processes, each taking in two number inputs:
- Add
- Subtract
- Multiply
- Divide

Bonus Challenges:
- Allow use of whole numbers and numbers with decimals
- Have the ability to return fractions or percentages instead of decimals
- Allow the calculator to take in as many numbers as the user provides
*/

// type    name = new constructor()
Calculator calc = new Calculator(); // new up a Calculator instance
int total = calc.Add(16, 42);
double totald = calc.Add(16, 42.0);
total = calc.Subtract(total, 5);
total = calc.Multiply(total, 9);
total = calc.Divide(total, 2);
Console.WriteLine(total);

class Calculator
{
    // Add Method
    public int Add(int numOne, int numTwo)
    {
        int sum = numOne + numTwo;
        return sum;
    }

    // Method Overloading
    // Same method name, different parameter types
    public double Add(double numOne, double numTwo)
    {
        return numOne + numTwo;
    }

    // Subtract Method
    public int Subtract(int numOne, int numTwo)
    {
        return numOne - numTwo;
    }

    // Multiply Method
    public int Multiply(int numOne, int numTwo) => numOne * numTwo;

    // Divide Method
    public int Divide(int numOne, int numTwo) => numOne / numTwo;
}

/*
accessModifier returnType Name(paramType paramName) { methodBody }
*/