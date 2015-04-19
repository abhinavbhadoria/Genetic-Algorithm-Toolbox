using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class FunctionParser
    {
        static int[] arr = new int[100005];

        public static void parse(char[] word, int wordlen)
        {
            int power = 0, start = 1, coeff = 0, i, negative = 0;

            if (word[0] == '-')
                negative = 1;
            if (word[0] == 'x' || (word[0] >= '0' && word[0] <= '9'))
                start = 0;
            else start = 1;
            for (i = start; i < wordlen && word[i] != 'x'; i++)
            {
                coeff = coeff * 10 + (word[i] - '0');
            }
            if (coeff == 0)
                coeff = 1;
            if (negative == 1)
                coeff *= -1;
            if (i == wordlen)
            {
                power = 0;
                arr[power] = coeff;
                return;
            }
            for (i = i + 2; i < wordlen; i++)
            {
                power = power * 10 + (word[i] - '0');
            }
            if (power == 0)
                power = 1;
            arr[power] = coeff;
        }

        public static int functionvalue(int n, int v)
        {
            int ans = 0, i;
            for (i = 0; i < n; i++)
            {
                ans += arr[i] * (int)Math.Pow(v, i);
            }
            return ans;
        }
        public static int calculate(string fitnessFunction, int value)
        {
            char[] fitnessFunctionWithoutSpaces = new char[100005];
            char[] word = new char[100005];
            int length = fitnessFunction.Length;
            int len = 0;

            for (int i = 0; i < 100005; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < length; i++)
            {
                if (fitnessFunction[i] == ' ')
                    continue;
                fitnessFunctionWithoutSpaces[len++] = fitnessFunction[i];
            }

            fitnessFunctionWithoutSpaces[len] = '\0';
            int counter = 0;
            int wordlen = 0;

            for (int i = 0; i < len; i++)
            {
                if (wordlen == 0 && (fitnessFunctionWithoutSpaces[i] == '+' || fitnessFunctionWithoutSpaces[i] == '-'))
                {
                    word[wordlen++] = fitnessFunctionWithoutSpaces[i];
                }
                else if (fitnessFunctionWithoutSpaces[i] == '-' || fitnessFunctionWithoutSpaces[i] == '+')
                {
                    word[wordlen] = '\0';
                    parse(word, wordlen);
                    counter++;
                    wordlen = 0;
                    i--;
                }
                else
                    word[wordlen++] = fitnessFunctionWithoutSpaces[i];
            }
            word[wordlen] = '\0';
            parse(word, wordlen);
            int ans = functionvalue(100, value);
            return ans;
        }
    }
}
