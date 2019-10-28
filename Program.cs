﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarize
{
    class GFG
    {
        // Function for finding sum of larger numbers 
        static string FindSum(string str1, string str2)
        {
            // Before proceeding further, make sure length 
            // of str2 is larger. 
            if (str1.Length > str2.Length)
            {
                string t = str1;
                str1 = str2;
                str2 = t;
            }

            // Take an empty string for storing result 
            string str = "";

            // Calculate length of both string 
            int n1 = str1.Length, n2 = str2.Length;

            // Reverse both of strings 
            char[] ch = str1.ToCharArray();
            Array.Reverse(ch);
            str1 = new string(ch);
            char[] ch1 = str2.ToCharArray();
            Array.Reverse(ch1);
            str2 = new string(ch1);

            int carry = 0;
            for (int i = 0; i < n1; i++)
            {
                // Do school mathematics, compute sum of 
                // current digits and carry 
                int sum = ((int)(str1[i] - '0') +
                        (int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');

                // Calculate carry for next step 
                carry = sum / 10;
            }

            // Add remaining digits of larger number 
            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(str2[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }

            // Add remaining carry 
            if (carry > 0)
                str += (char)(carry + '0');

            // reverse resultant string 
            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);

            return str;
        }

        delegate string ReadLine();

        // Driver code 
        static void Main()
        {
            string str1 = new ReadLine(Console.ReadLine);
            string str2 = new ReadLine(Console.ReadLine);
            Console.WriteLine(FindSum(str1, str2));
        }
    }

    // This code is contributed by mits 

}
