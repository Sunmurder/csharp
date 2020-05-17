using System;
using System.Diagnostics;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        //exercise is to clean the input (e.g. +1 (613)-995-0253 to 6139950253
        //format (NXX)-NXX-XXXX where 2<n<9 && 0<x<9

        //(223) 456-7890 => 2234567890

        string phoneNumberArray = new string(phoneNumber.Where(c => char.IsDigit(c)).ToArray()).ToString(); // (223) 456-7890 => 2234567890
        if (phoneNumberArray.Length <=9 || phoneNumberArray.Length >= 12) // lenght 2234567890 = 10
            throw new ArgumentException(); //falls through
        else if (phoneNumberArray.Length == 11 && phoneNumberArray[0] == 1 && phoneNumberArray[1] >= 2 && phoneNumberArray[4] >= 2) //falls through
            return phoneNumberArray = phoneNumberArray.Remove(0, 1);
        else if (phoneNumberArray.Length == 10 && phoneNumberArray[0] >= 2 && phoneNumberArray[3] >= 2) // lenght 2234567890 = 10, [0]=2, [3]<9
            return phoneNumberArray; //above is true. Return the number
        throw new ArgumentException(); //, N is less than 2
    }
}