using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {

        public double[] Create5Numbers()
        {
            double[] numbers = new double[5];
            numbers[0] = 4;
            numbers[1] = 6;
            numbers[2] = 8;
            numbers[3] = 10;
            numbers[4] = 12;
            Console.WriteLine(numbers);
            return numbers;
        }

        public double GetSecond(double[] numbers)
        {
            
            return numbers[1];
        }
    }
}