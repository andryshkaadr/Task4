namespace Task4
{
    using System;
    using System.Numerics;

    public class ComplexNumber
    {
        private double module;
        private double argument;

        public ComplexNumber(double module, double argument)
        {
            this.module = module;
            this.argument = argument;
        }

        public override string ToString()
        {
            return $"({module} * e^({argument}i))";
        }


        /// <summary>
        /// function of raising to the root of a power of a complex number
        /// </summary>
        /// <param name="power">power</param>
        /// <returns>root of a complex number</returns>
        public ComplexNumber InRoot(double power)
        {
            double newModule = Math.Pow(module, 1.0 / power);
            double newArgument = argument / power;
            return new ComplexNumber(newModule, newArgument);
        }

        /// <summary>
        /// Сomplex number summation function
        /// </summary>
        /// <param name="left">number1</param>
        /// <param name="right">number2</param>
        /// <returns>sum</returns>
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            double realPart = left.module * Math.Cos(left.argument) + right.module * Math.Cos(right.argument);
            double imaginaryPart = left.module * Math.Sin(left.argument) + right.module * Math.Sin(right.argument);
            double newModule = Math.Sqrt(Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2));
            double newArgument = Math.Atan2(imaginaryPart, realPart);
            return new ComplexNumber(newModule, newArgument);
        }

        /// <summary>
        /// complex number difference function
        /// </summary>
        /// <param name="left">number1</param>
        /// <param name="right">number2</param>
        /// <returns>difference</returns>
        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            double realPart = left.module * Math.Cos(left.argument) - right.module * Math.Cos(right.argument);
            double imaginaryPart = left.module * Math.Sin(left.argument) - right.module * Math.Sin(right.argument);
            double newModule = Math.Sqrt(Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2));
            double newArgument = Math.Atan2(imaginaryPart, realPart);
            return new ComplexNumber(newModule, newArgument);
        }

        /// <summary>
        /// complex number multiplication function
        /// </summary>
        /// <param name="left">number 1</param>
        /// <param name="right">number 2</param>
        /// <returns>multiplication</returns>
        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            double newModule = left.module * right.module;
            double newArgument = left.argument + right.argument;
            return new ComplexNumber(newModule, newArgument);
        }

        /// <summary>
        /// complex number division function
        /// </summary>
        /// <param name="left">dividend</param>
        /// <param name="right">divisor</param>
        /// <returns>quotient</returns>
        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            double newModule = left.module / right.module;
            double newArgument = left.argument - right.argument;
            return new ComplexNumber(newModule, newArgument);
        }
    }
}