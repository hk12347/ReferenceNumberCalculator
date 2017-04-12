using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceNumberCalculator
{
    /// <summary>
    /// 
    /// Class for a reference number calculation
    /// </summary>
    public class RefNumberCalculator
    {
        /// <summary>
        /// Reference number calculation: Multiplies the value by 1 / 3 / 7 (abcd -> 1*a + 3*b + 7*c + 1*d ...) and substracts the outcome from the nearest ten.
        /// E.g. 123456 ref number is 1.
        /// </summary>
        /// <param name="intInputNumber">Input value</param>
        public int Calculate(Int64 numbers)
        {

            int result, value, x, y;
            int nearestTen;
            String _numbers;
            String _number;

            result = 0;
            value = 0;
            x = 0;
            y = 0;

            _numbers = numbers.ToString();

            do
            {
                _number = _numbers.Substring(x, 1);

                switch (y)
                {
                    case 0:
                        value = 1 * int.Parse(_number);
                        break;
                    case 1:
                        value = 3 * int.Parse(_number);
                        break;
                    case 2:
                        value = 7 * int.Parse(_number);
                        break;
                }

                if (y < 2) { y += 1; }
                else { y = 0; }

                x += 1;
                result = result + value;

            } while (x < _numbers.Length);

            nearestTen = 10 * ((result + 5) / 10); 
            if (nearestTen < result)
            {
                nearestTen = 10 * ((result + 15) / 10);
            }
            result = nearestTen - result;

            return result;
        }
    }
}
