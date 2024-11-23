using System;
using System.Globalization;
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

        private static readonly Dictionary<char, Func<int, int, int>> operations = new
         Dictionary<char, Func<int, int, int>>
         {
            {'+', (a, b) => a + b},
            {'-', (a, b) => a - b }
         };

         public int Calculate(string input)
         {
            input = input.Replace(" ", "");
            
            var number = input.Split(new[] { '+', '-'},
             StringSplitOptions.RemoveEmptyEntries);
            var operators = input.Where(c => c == '+' || c == '-').ToArray();

            if(!int.TryParse(numbers[0], out int result))
            {
                throw new ArgumentException("invalid input");
            }
            for(var i = 0; i < operators.Length; i++)
            {
                if(!int.TryParse(numbers[i+1], out int number))
                {
                    throw new ArgumentException("Invalid input");
                }

                char op = operations[i];
                if(operations.TryGetValue(op, out var operation))
                {
                    result = operation(result, number);
                }
                else
                {
                     throw new ArgumentException($"Unsupported operator: {op}");
                }

                return result;

            }
         }

    }






}