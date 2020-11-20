using System;
using System.Linq;
using System.Text;

namespace Framework.Core
{
    public static class LauhnExtensions
    {
        public static string GenerateLauhn()
        {
            int[] checkArray = new int[15];

            var cardNum = new int[16];

            for (int d = 14; d >= 0; d--)
            {
                cardNum[d] = new Random().Next(0, 9);
                checkArray[d] = (cardNum[d] * (((d + 1) % 2) + 1)) % 9;
            }

            cardNum[15] = (checkArray.Sum() * 9) % 10;

            var sb = new StringBuilder();

            for (int d = 0; d < 16; d++)
            {
                sb.Append(cardNum[d].ToString());
            }
            return sb.ToString();
        }
        public static bool CheckLauhn(this string cardNo)
        {
            try
            {
                int nDigits = cardNo.Length;

                int nSum = 0;
                bool isSecond = false;
                for (int i = nDigits - 1; i >= 0; i--)
                {

                    int d = cardNo[i] - '0';

                    if (isSecond == true)
                        d = d * 2;

                    // We add two digits to handle 
                    // cases that make two digits  
                    // after doubling 
                    nSum += d / 10;
                    nSum += d % 10;

                    isSecond = !isSecond;
                }
                return (nSum % 10 == 0);
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}