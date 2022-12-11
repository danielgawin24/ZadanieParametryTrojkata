using System;

namespace TriangleParameter;

class Program
{
    public static void TriangleParameter()
    {
        // Input and converting
        string input = Console.ReadLine();
        string[] triangleSides = input.Split("; ");

        input = String.Format("{0:.00}", input);

        decimal a = Convert.ToDecimal(String.Format("{0:.00}", triangleSides[0]));
        decimal b = Convert.ToDecimal(String.Format("{0:.00}", triangleSides[1]));
        decimal c = Convert.ToDecimal(String.Format("{0:.00}", triangleSides[2]));

        decimal aTo2 = Convert.ToDecimal(Math.Pow((double)a, 2));
        decimal bTo2 = Convert.ToDecimal(Math.Pow((double)b, 2));
        decimal cTo2 = Convert.ToDecimal(Math.Pow((double)c, 2));

        //Calculating triangle perimeter
        decimal perimeterMath = (a + b + c);
        decimal trianglePerimeter = Convert.ToDecimal(String.Format("{0:.00}", perimeterMath));

        //handling exceptions when triangle cannot be build or sides in input are below zero
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Wrong input. Triangle sides must have value more than zero!");
            return;
        }
        if (a > b + c || b > c + a || c > b + a)
        {
            Console.WriteLine("Wrong input. Triangle cannot be build!");
            return;
        }

        //printing perimeter
        Console.WriteLine($"Perimeter = {trianglePerimeter}");

        //calculating triangle area
        decimal p = (a + b + c) / 2;
        decimal underRoot = p * (p - a) * (p - b) * (p - c);
        decimal areaMath = Convert.ToDecimal(Math.Sqrt((double)underRoot));
        decimal TriangleArea = Convert.ToDecimal(String.Format("{0:.00}", areaMath));

        //printing area
        Console.WriteLine($"Area = {TriangleArea}");

        //printing if triangle is rectangular, obtuse or acute
        if (aTo2 == bTo2 + cTo2 || bTo2 == cTo2 + aTo2 || cTo2 == aTo2 + bTo2)
        {
            Console.WriteLine("triangle is rectangular");
        }
        else if (aTo2 > bTo2 + cTo2 || bTo2 > cTo2 + aTo2 || cTo2 > aTo2 + bTo2)
        {
            Console.WriteLine("triangle is obtuse");
        }
        else if (aTo2 < bTo2 + cTo2 || bTo2 < cTo2 + aTo2 || cTo2 < aTo2 + bTo2)
        {
            Console.WriteLine("triangle is acute");
        }

        //printing if triangle is equilateral or isosceles
        if (a == b && b == c && c == a)
        {
            Console.WriteLine("triangle is equilateral");
        }
        else if (a == b || b == c || c == a)
        {
            Console.WriteLine("triangle is isosceles");
        }
    }
}