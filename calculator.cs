using System;
namespace temperatureapp
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public int Add(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

    }






}