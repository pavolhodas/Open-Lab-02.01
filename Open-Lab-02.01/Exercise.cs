using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {

        public double[] Create5Numbers()
        {
            double[] numbers = new double[5] {4, 6, 8, 10, 12 };
            return numbers;
        }

        public double GetSecond(double[] numbers)
        {
            
            return numbers[1];
        }
    }
}