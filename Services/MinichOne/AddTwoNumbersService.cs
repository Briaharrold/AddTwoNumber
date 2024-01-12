namespace AddTwoNumber.Services.MinichOne;

    public class AddTwoNumbersService : IAddTwoNumbersService
    {
    public string Add(string firstNum, string secondNum)
        {
            bool isTrue = double.TryParse(firstNum, out double num1);
            bool isTrue2 = double.TryParse(secondNum, out double num2);

            if (isTrue == true && isTrue2 == true)
            {
                double total = num1 + num2;
                return "The Sum of " + num1 + " and " + num2 + " is " + total;
            }
            else
            {
                return "Invalid Input.Please Type a Vailid Number";
            }
        }
    }
