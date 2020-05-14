using System;
using System.Diagnostics;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        //exercise is to clean the input (e.g. +1 (613)-995-0253 to 6139950253
        //format (NXX)-NXX-XXXX where 2<n<9 && 0<x<9
        string phoneNumberArray = new string(phoneNumber.Where(c => char.IsDigit(c)).ToArray()).ToString();
       if (phoneNumberArray.Length == 11 && phoneNumberArray[0] == 1 && phoneNumberArray[1] >= 2 && phoneNumberArray[3] >= 2) //checking if number is 11 digits long, checking for N and return if true, delete 1st digit and return
            return phoneNumberArray = phoneNumberArray.Remove(0, 1);
        else if (phoneNumberArray.Length == 10 && phoneNumberArray[0] >= 2 && phoneNumberArray[3] >= 2) // checking for 10 digits long and for N. return if true
            return phoneNumberArray;
        throw new ArgumentException(); //all else exception, where lenght>11 or <9, N is less than 2
    }
}