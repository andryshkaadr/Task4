namespace Task4
{
    using System;
    class Program
    {
        static void Main()
        {
            ComplexNumber a = new ComplexNumber(3, Math.PI / 4); // Example: 3 * e^(π/4i)
            ComplexNumber b = new ComplexNumber(4, Math.PI / 3); 
            ComplexNumber c = new ComplexNumber(1, Math.PI / 6); 
            ComplexNumber d = new ComplexNumber(2, Math.PI / 2); 
            double power = 5;

            ComplexNumber result = b + a - (b / c) * d.InRoot(power);

            Console.WriteLine($"{b} + {a} - ( {b} / {c} ) * {d}^1/{power} = {result}");
        }
    }
}