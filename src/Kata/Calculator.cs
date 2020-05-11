using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input = "")
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            if (input.Contains(','))
            {
                var numbers = input.Split(',');
            
                return int.Parse(numbers.First()) + int.Parse(numbers.Last());
            }
            
            return int.Parse(input);
        }
    }
}