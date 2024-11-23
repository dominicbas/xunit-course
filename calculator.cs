using System;
namespace temperatureapp
{
    public class Calculator
    {
        public List<int> History {get; private set; }
        public Calculator()
        {
            History = new List<int>();

        }
        public int Add(params int[] numbers)
        {
          
          var result = numbers.Sum();
          History.Add(result);
          return result;

        }

        public int Substract(params int[] numbers)
        {
            return numbers.Aggregate((a,b) => a-b);
        }

    }






}