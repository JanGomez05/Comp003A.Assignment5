/*
 * 
 * Author: Jan Gomez
 * Course: Comp 003A L01
 * Purpose: USing XML comments and understanding Methods
 * 
 */
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

        Console.WriteLine("Enter value for your birthyear: ");
        int year = Convert.ToInt32(Console.ReadLine());
        AgeCalculator(year);
        Console.WriteLine($"Your age is: {AgeCalculator(year)}");

        PrintSeparator();
        PrintSeparator("Favorite Characters");
        PrintSeparator();
        CharacterInfo("Harry Styles", AgeCalculator(1994));
        CharacterInfo("Doja Cat", AgeCalculator(1995));
        CharacterInfo("Quinta Brunson", AgeCalculator(1989));
        CharacterInfo("Seth Rogan", AgeCalculator(1982));
        CharacterInfo("Pablo Neruda", AgeCalculator(1904));

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
        Console.WriteLine($"{title}");
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
    static int AgeCalculator(int year)
    {
        return DateTime.Now.Year - year;
    }
    /// <summary>
    /// Method using recrusion
    /// </summary>
    /// <param name="name"></param>
    /// <param name="birthYear"></param>
    static void CharacterInfo(string name, int birthYear)
    {
        int age = AgeCalculator(birthYear);
        Console.WriteLine($"\t {name} turns {age} this year!");
    }
}
