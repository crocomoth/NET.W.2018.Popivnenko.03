using System.Diagnostics;

namespace NET.W._2018.Popivnenko._03.EvklidProj
{
    /// <summary>
    /// Class that allow to get GCD of several (two,three etc.) numbers
    /// in two ways.
    /// </summary>
    public class ClassicEvklid
    {
        private Stopwatch stopwatch = new Stopwatch();

        private long ticks;

        /// <summary>
        /// Method called to get elapsed time during last calculation.
        /// </summary>
        /// <returns>Last calculation time in ticks.</returns>
        public long GetTimeOfExecution()
        {
            return ticks;
        }

        /// <summary>
        /// Method that calculates GCD of several numbers.
        /// Uses dividing and modulo in calcuclations.
        /// </summary>
        /// <param name="numbers">Parameters(integers) transfered into method.</param>
        /// <returns>GCD of all parameters or -1 in case of errors.</returns>
        public int ClassicEuclidMethod(params int[] numbers)
        {
            stopwatch.Reset();
            stopwatch.Start();
            if (numbers.Length < 2)
            {
                stopwatch.Stop();
                ticks = stopwatch.ElapsedTicks;
                return -1;
            }
            int result = EvklidForTwoNumbers(numbers[0], numbers[1]);
            for (int i = 2;i<numbers.Length - 1;i++)
            {
                result = EvklidForTwoNumbers(result, numbers[i]);
            }
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }

        /// <summary>
        ///  Method that calculates GCD of several numbers.
        ///  Uses shifts and substracting in calculations.
        /// </summary>
        /// <param name="numbers">Parameters(integers) transfered into method.</param>
        /// <returns>GCD of all parameters or -1 in case of errors.</returns>
        public int BinaryEuclidMethod(params int[] numbers)
        {
            stopwatch.Reset();
            stopwatch.Start();
            if (numbers.Length < 2)
            {
                stopwatch.Stop();
                ticks = stopwatch.ElapsedMilliseconds;
                return -1;
            }
            int result = EvklidForTwoNumbers(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length - 1; i++)
            {
                result = BinaryEuclid(result, numbers[i]);
            }
            stopwatch.Stop();
            ticks = stopwatch.ElapsedTicks;
            return result;
        }

        private int EvklidForTwoNumbers(int num1,int num2)
        {
            while (num2 != 0)
            {
                int buf = num2;
                num2 = num1 % num2;
                num1 = buf;
            }
            return num1;
        }

        private int BinaryEuclid(int num1,int num2)
        {
            if (num1 == 0)
            {
                return num2;
            }
            if (num2 == 0)
            {
                return num1;
            }


            //shift numbers gor easier use result needs to be shifted back
            int shift = 0;
            for (shift = 0; ((num1 % 2==0) && (num2 % 2 == 0));shift++)
            {
                num1 >>= 1;
                num2 >>= 1;
            }

            //we need to be sure that num2 is odd
            while (num2 % 2 ==0)
            {
                num2 >>= 1;
            }


            do
            {
                while (num1 % 2 == 0)
                {
                    num1 >>= 1;
                }

                if (num1 > num2)
                {
                    int tmp = num1;
                    num1 = num2;
                    num2 = tmp;
                }

                num2 = num2 - num1;
            }
            while (num2 != 0);

            return num1 >> shift;
        }
    }
}
