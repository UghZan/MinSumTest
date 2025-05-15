using System.Linq;

namespace MinSumTest.Main
{
    public class MinSumCalc
    {
        static Random rand = new Random((int) DateTime.Now.Ticks);
        static void Main(string[] args)
        {
            int[] input = GenerateRandomValues(1000, -100000, 100000);

            int calcMin1 = 0, calcMin2 = 0;

            int compRes = LINQ_CalculateSum(input, ref calcMin1, ref calcMin2);
            Console.WriteLine("Expected result: {0} ({1} + {2})", compRes, calcMin1, calcMin2);

            int res = CalculateSum(input, ref calcMin1, ref calcMin2);
            Console.WriteLine("Calculated result: {0} ({1} + {2})", res, calcMin1, calcMin2);
        }

        public static int LINQ_CalculateSum(int[] input, ref int min1, ref int min2)
        {
            if (input.Length == 0) return 0;
            int in1 = input.Min();

            var interResult = input.ToList();
            interResult.RemoveAll(x => x == in1);

            int in2 = in1;
            if (interResult.Count != 0) in2 = interResult.Min();

            min1 = in1;
            min2 = in2;
            return in1 + in2;
        }

        public static int CalculateSum(int[] input, ref int min1, ref int min2)
        {
            if (input.Length == 0) return 0;
            if (input.Length == 1)
            {
                min1 = min2 = input[0];
                return input[0]*2;
            }
            min1 = min2 = int.MaxValue;
            int idx = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min1)
                {
                    min1 = input[i];
                    if(min2 > input[idx] && input[idx] != min1)
                        min2 = input[idx];
                    idx = i;
                }
                else
                {
                    if (min2 > input[i] && input[i] > min1)
                    {
                        min2 = input[i];
                    }
                }
            }
            if(min2  == int.MaxValue)
            {
                min2 = min1;
            }
            return min1 + min2;
        }

        /*
         if (input.Length == 0) return 0;
            if (input.Length == 1)
            {
                min1 = min2 = input[0];
                return input[0]*2;
            }
            min1 = min2 = int.MaxValue;
            int tmp = 0, min1_prev = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                var val = input[i];
                var reverseVal = input[input.Length - i - 1];
                if (val < min1)
                {
                    min1_prev = min1;
                    min1 = input[i];
                }
                if (reverseVal < min2 && reverseVal != min1)
                {
                    min2 = reverseVal;
                    if (min2 < min1)
                    {
                        tmp = min1;
                        min1 = min2;
                        min2 = tmp;
                    }
                }
            }
            if (min2 > min1_prev) //на случай, если 
            {
                min2 = min1_prev;
            }
            if (min2 == int.MaxValue && min1_prev == int.MaxValue) //можем с уверенностью утверждать, что ни min1, ни min2 ни разу не изменились, так что скорее всего массив весь из 1 числа
            {
                min2 = min1;
            }
            return min1 + min2;*/
        public static int[] GenerateRandomValues(int amount, int min, int max)
        {
            int[] res = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                res[i] = rand.Next(min, max);
            }
            return res;
        }
    }
}
