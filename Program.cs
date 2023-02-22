/*
 * 
 * Author: Jan Gomez
 * Course: Comp 003A L01
 * Purpose: USing XML comments and understanding Methods
 * 
 */
namespace Comp003A.Assignment5;
class Program
{
    static void Main(string[] args)
    {
        

        PrintSeparator();
        PrintSeparator("Triangle Section");
        PrintSeparator();

        Console.WriteLine("Enter a single character: ");
        char inputCharacter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter a positive number: ");
        int size = Convert.ToInt32(Console.ReadLine());

        IsoscelesTriangleBuilder(inputCharacter, size);

        PrintSeparator();
        PrintSeparator("Age Calculator");
        PrintSeparator();
        Console.WriteLine("Enter value for current year: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter value for your birthyear: ");
        decimal year = Convert.ToDecimal(Console.ReadLine());
        AgeCalculator(num1, year);
        Console.WriteLine($"Your age is: {AgeCalculator(num1, year)}");

        PrintSeparator();
        PrintSeparator("Favorite Characters");
        PrintSeparator();
        CharacterInfo("Harry Styles", DateTime.Now.Year - 1994);
        CharacterInfo("Doja Cat", DateTime.Now.Year - 1995);
        CharacterInfo("Quinta Brunson", DateTime.Now.Year - 1989);
        CharacterInfo("Seth Rogen", DateTime.Now.Year - 1982);
        CharacterInfo("Pablo Neruda", 1973 - 1904);
    }// end of Main code

    /// <summary>
    /// creating the 50 stars
    /// </summary>
    static void PrintSeparator()
    {
        Console.WriteLine("".PadRight(50, '*'));
    }

    /// <summary>
    /// Naming title
    /// </summary>
    /// <param name="title"></param>
    static void PrintSeparator(string title)
    {
        Console.WriteLine(title);
    }

    /// <summary>
    /// Using methods and a for loop statement with incremental and decremental
    /// only using 2 params with no return value
    /// </summary>
    /// <param name="inputCharacter"></param>
    /// <param name="size"></param>
    static void IsoscelesTriangleBuilder(char inputCharacter, int size)
    {

        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine("".PadRight(i, inputCharacter));

        }

        for (int i = size - 1; i >= 1; i--)
        {
            Console.WriteLine("".PadRight(i, inputCharacter));

        }
    }
    /// <summary>
    /// Using a method with a return value
    /// </summary>
    /// <param name="num1">Decimal input</param>
    /// <param name="year">Decimal input</param>
    /// <returns> Subtraction</returns>
    static decimal AgeCalculator(decimal num1, decimal year)
    {
        return num1 - year;
    }
    /// <summary>
    /// Method using recrusion
    /// </summary>
    /// <param name="name"></param>
    /// <param name="birthYear"></param>
    static void CharacterInfo(string name, int birthYear)
    {
        Console.WriteLine($"{name}, {birthYear}");
    }
}
