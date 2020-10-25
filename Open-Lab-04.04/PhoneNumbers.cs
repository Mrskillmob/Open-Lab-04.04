using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string q = "(" + numbers[0] + numbers[1] + numbers[2] + ")";
            string w = " " + numbers[3] + numbers[4] + numbers[5] + "-";
            string e = q + w + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            return e;
        }
    }
}
