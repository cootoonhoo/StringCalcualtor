using System.Linq;

namespace StringCalculator.Domain
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if(string.IsNullOrEmpty(numbers))
            return 0;

            if (numbers.Split(",").Length != 2) {
                throw new ArgumentException("Quantidade de numeros inválidos");
            }

            foreach (string number in numbers.Split(",")){
                if (!int.TryParse(number, out _)) {
                    throw new ArgumentException("Input não aceito");
                }
            }
            int a, b;
            a = int.Parse(numbers.Split(",")[0]);
            b = int.Parse(numbers.Split(",")[1]);
            return a+b;
        }
    }
}