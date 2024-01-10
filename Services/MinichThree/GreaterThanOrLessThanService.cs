
namespace AddTwoNumber.Services.MinichThree
{
    public class GreaterThanOrLessThanService
    {
    public string Greater(string firstNumber, string secondNumber)
        {
          double num2 = 0;
               
            bool realNum = double.TryParse(firstNumber, out double num1) && double.TryParse( secondNumber, out num2);

            if (realNum == true)
            {
                if (num1 > num2)
                {
                    return firstNumber + " is greater than " + secondNumber + "and" + secondNumber + " is less than " + firstNumber;
                }
                else if (firstNumber == secondNumber)
                {
                    return firstNumber + " is equal to " + secondNumber;
                }
                 else if (num1 < num2)
                {
                    return secondNumber + " is greater than " + firstNumber + "and" + firstNumber + " is less than " + secondNumber;
                }
                else
                {
                    return firstNumber + " is less than " + secondNumber + "and" + secondNumber + " is greater than " + firstNumber;
                }

            
            }
            else
            {
                return "Invalid input. Please enter a number.";
            }

    }
}
}