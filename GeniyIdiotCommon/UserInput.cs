using System;


namespace GeniyIdiot.Common
{
    public static class UserInput
    {
        public static bool TryParseNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                number = 0;
                errorMessage = "Введите число";
                return false;
            }
            catch (OverflowException)
            {
                number = 0;
                errorMessage = "Введите число от -2*10^6 до 2*10^6";
                return false;
            }
        }
      
        public static bool ValidateUserName(string text)
        {
            return (text != "");
        }


        public static bool ValidateUserQuestion(string text)
        {
            return (text.Length > 10);
        }

    }
}








