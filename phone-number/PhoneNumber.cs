using System;
using System.Diagnostics;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
       char[] phoneNumberArray = phoneNumber.Where(c => char.IsDigit(c)).ToArray(); //removing characters (223) 456-7890 => 2234567890
       if (phoneNumberArray.Length == 11 && (int)Char.GetNumericValue(phoneNumberArray[0]) == 1 && (int)Char.GetNumericValue(phoneNumberArray[1]) >= 2 && (int)Char.GetNumericValue(phoneNumberArray[4]) >= 2) //get numeric value from char array and roll through conditions
            return new String(phoneNumberArray, 1, 10);//return string dropping +1;
        else if (phoneNumberArray.Length == 10 && (int)Char.GetNumericValue(phoneNumberArray[0]) >= 2 && (int)Char.GetNumericValue(phoneNumberArray[3]) >= 2) // get numeric value from char array and compare to given conditions
            return new string(phoneNumberArray); //return string
        throw new ArgumentException(); //all else are exceptions
    }
}