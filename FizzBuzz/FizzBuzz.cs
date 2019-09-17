namespace FizzBuzzKataTest
{
    public class FizzBuzz
    {
        
        public string Convert(int number)
        {
            string numbers = "";
            for(int i = 1; i<= number; i++)
            {
                numbers += GetFizzBuzz(i);
                numbers += GetFizz(i);
                numbers += GetBuzz(i);
                numbers += GetOnlyNumber(i);
            }
            return numbers.Trim();
        }
        private string GetFizzBuzz(int number)
        {
              return IsDivisibleByThree(number) && IsDivisibleByFive(number) ? "FizzBuzz " : "";
        }
        private string GetOnlyNumber(int number)
        {
            return !IsDivisibleByFive(number) && !IsDivisibleByThree(number) ? number.ToString() + " " : "";
        }
        private string GetFizz(int number)
        {
            return (IsDivisibleByThree(number) && !IsDivisibleByFive(number)) ? "Fizz " : "";
        }
        private string GetBuzz(int number)
        {
            return IsDivisibleByFive(number) && !IsDivisibleByThree(number) ? "Buzz " : "";
         }
        private bool IsDivisibleByThree(int i)
        {
            return i % 3 == 0;
        }
        private bool IsDivisibleByFive(int i)
        {
            return i % 5 == 0;
        }
    }
}