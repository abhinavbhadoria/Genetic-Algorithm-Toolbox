using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Mutation
    {
        static Random rnd = new Random();

        static string[,] offspringBefore;
        static string[,] mutationChromosome;
        static string[,] offspringAfter;
        static int[,] xVal;
        static int[,] fitnessVal;

        public static DataTable InitializeTable()
        {
            DataTable table = new DataTable();

            if (DataStorage.isTSP)
            {
                table.Columns.Add("StringNo", typeof(string));
                table.Columns.Add("OffspringBefore", typeof(string));
                table.Columns.Add("MutationChromosome", typeof(string));
                table.Columns.Add("OffspringAfter", typeof(string));
                table.Columns.Add("Fitness", typeof(string));
                for (int i = 0; i < 4; i++)
                    table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            else
            {
                table.Columns.Add("StringNo", typeof(string));
                table.Columns.Add("OffspringBefore", typeof(string));
                table.Columns.Add("MutationChromosome", typeof(string));
                table.Columns.Add("OffspringAfter", typeof(string));
                table.Columns.Add("x-value", typeof(string));
                table.Columns.Add("Fitness", typeof(string));
                for (int i = 0; i < 4; i++)
                    table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            }

            return table;
        }

        // ----------------------------------------------------------------------------------------------------
        //                                      Function Maximize related functions
        // ----------------------------------------------------------------------------------------------------

        public static int[,] DoMutation(int[,] initialChromosome, ref DataTable mainTable, ref int[] maxima)
        {
            offspringBefore = new string[4, DataStorage.initialPopCount];
            mutationChromosome = new string[4, DataStorage.initialPopCount];
            offspringAfter = new string[4, DataStorage.initialPopCount];
            xVal = new int[4, DataStorage.initialPopCount];
            fitnessVal = new int[4, DataStorage.initialPopCount];

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    mutationChromosome[gen, i] = string.Empty;
                    offspringBefore[gen, i] = Utility.DecToBin(initialChromosome[gen, i]);
                }
            }

            PerformMutationrRateFunctionMaximize(DataStorage.mutationRate, ref offspringBefore, ref offspringAfter, ref mutationChromosome);

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    xVal[gen, i] = Utility.BinToDec(offspringAfter[gen, i]);
                    fitnessVal[gen, i] = FunctionParser.calculate(DataStorage.fitnessFunction, xVal[gen, i]);
                }
            }

            for (int gen = 0; gen < 4; gen++)
                maxima[gen] = Utility.GetMax(xVal, gen);

            // Updating mutation table
            UpdateTableValue(ref mainTable);

            return xVal;
        }
        private static void OnePointMutationFunctionMaximize(string str, out string offspring, out string mutationChromosome)
        {
            int[] arr1 = new int[] { 1, 2, 4, 8, 16 };
            char[] ch = new char[5];

            int number = rnd.Next(5);
            number = arr1[number];
            ch = Utility.DecToBin(number).ToCharArray();
            char[] array1 = str.ToCharArray();
            int x, y, z;
            for (int i = 0; i < 5; i++)
            {
                x = (int)(array1[i] - '0');
                y = (int)(ch[i] - '0');
                z = x ^ y;
                array1[i] = (char)(z + '0');


            }

            offspring = new String(array1);
            mutationChromosome = Utility.DecToBin(number);
        }
        private static void MultiPointMutationFunctionMaximize(string str, out string offspring, out string mutationChromosome)
        {
            char[] ch = new char[5];

            int number = rnd.Next(32);

            while ((number & (number - 1)) == 0)
                number = rnd.Next(32);

            ch = Utility.DecToBin(number).ToCharArray();
            char[] array1 = str.ToCharArray();
            int x, y, z;
            for (int i = 0; i < 5; i++)
            {
                x = (int)(array1[i] - '0');
                y = (int)(ch[i] - '0');
                z = x ^ y;
                array1[i] = (char)(z + '0');
            }

            offspring = new String(array1);
            mutationChromosome = Utility.DecToBin(number);
        }
        public static void PerformMutationrRateFunctionMaximize(int rate, ref string[,] inputchromosome, ref string[,] outputchromosome, ref string[,] mutChormosome)
        {
            for (int gen = 0; gen < 4; gen++)
            {
                int length = inputchromosome.GetLength(1);

                int selectedvalues = (int)((rate / 100f) * length);
                if ((selectedvalues % 2) == 1)
                    selectedvalues--;

                int[] temp = new int[length];
                for (int i = 0; i < length; i++)
                    temp[i] = Utility.BinToDec(inputchromosome[gen, i]);

                Array.Sort(temp);

                for (int i = 0; i < length; i++)
                {
                    inputchromosome[gen, i] = Utility.DecToBin(temp[i]);
                    outputchromosome[gen, i] = Utility.DecToBin(temp[i]);
                }

                for (int i = 0; i < selectedvalues; i++)
                {
                    if (DataStorage.mutationType == DataStorage.mutationSchemes[0])
                        OnePointMutationFunctionMaximize(inputchromosome[gen, i], out outputchromosome[gen, i], out  mutChormosome[gen, i]);
                    else
                        MultiPointMutationFunctionMaximize(inputchromosome[gen, i], out outputchromosome[gen, i], out  mutChormosome[gen, i]);
                }

                for (int i = selectedvalues; i < DataStorage.initialPopCount; i++)
                    mutChormosome[gen, i] = "Nil";
            }
        }

        // ----------------------------------------------------------------------------------------------------
        //                                      TSP related functions
        // ----------------------------------------------------------------------------------------------------

        public static string[,] DoMutation(string[,] initialPath, ref DataTable mainTable, ref int[] minima, ref string[] minimaPath)
        {
            offspringBefore = new string[4, DataStorage.initialPopCount];
            mutationChromosome = new string[4, DataStorage.initialPopCount];
            offspringAfter = new string[4, DataStorage.initialPopCount];
            fitnessVal = new int[4, DataStorage.initialPopCount];

            offspringBefore = initialPath;

            PerformMutationrRateTSP(DataStorage.mutationRate, ref offspringBefore, ref offspringAfter, ref mutationChromosome);

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    fitnessVal[gen, i] = Utility.PathFitnessCalculator(offspringAfter[gen, i], DataStorage.distanceGraph);
            }

            for (int gen = 0; gen < 4; gen++)
            {
                minima[gen] = Utility.GetMin(fitnessVal, gen);
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    if (fitnessVal[gen, i] == minima[gen])
                        minimaPath[gen] = offspringAfter[gen, i];
                }
            }

            // Updating mutation table
            UpdateTableValue(ref mainTable);

            return offspringAfter;
        }
        public static string NPOintMutationTSP(string input, out string offspring, out string mutationChromosome, int CityCount, int singleOrMultiple)
        {
            int[] mutated = new int[CityCount];
            string ans = string.Empty;
            int multitime = 1;
            if (singleOrMultiple == 1)
            {
                multitime = rnd.Next(CityCount);
                while (multitime == 1)
                    multitime = rnd.Next(CityCount);
            }

            for (int k = 0; k < multitime; k++)
            {
                int temp1 = rnd.Next(CityCount);
                int temp2 = rnd.Next(CityCount);
                while (temp1 == temp2)
                    temp2 = rnd.Next(CityCount);
                mutated[temp1]++;
                mutated[temp2]++;
                char[] characters = input.ToCharArray();
                char ch = characters[temp1];
                characters[temp1] = characters[temp2];
                characters[temp2] = ch;
                input = new string(characters);
            }

            offspring = input;
            mutationChromosome = string.Empty;
            for (int i = 0; i < CityCount; i++)
                mutationChromosome += mutated[i].ToString();

            return mutationChromosome;
        }
        public static void PerformMutationrRateTSP(int rate, ref string[,] inputchromosome, ref string[,] outputchromosome, ref string[,] mutChormosome)
        {
            int length = inputchromosome.GetLength(1);
            int selectedvalues = (int)((rate / 100f) * length);
            if ((selectedvalues % 2) == 1)
                selectedvalues--;

            for (int gen = 0; gen < 4; gen++)
            {
                int[] tempFitness = new int[length];
                string[] tempChromosome = new string[length];
                // Calculating fitnessValue of chromosomes
                for (int i = 0; i < length; i++)
                {
                    tempFitness[i] = Utility.PathFitnessCalculator(inputchromosome[gen, i], DataStorage.distanceGraph);
                    tempChromosome[i] = inputchromosome[gen, i];
                }
                // Sorting chromosomes based on their fitness level and also keeping track of thier chromosomes
                Utility.SortChromosomes(ref tempFitness, ref tempChromosome);
                // Initially, inputChomosomes and outputChromosomes are same and sorted based in thier fitness value
                for (int i = 0; i < length; i++)
                    inputchromosome[gen, i] = outputchromosome[gen, i] = tempChromosome[i];

                for (int i = 0; i < selectedvalues; i++)
                {
                    if (DataStorage.mutationType == DataStorage.mutationSchemes[0])
                        NPOintMutationTSP(inputchromosome[gen, i], out outputchromosome[gen, i], out  mutChormosome[gen, i], DataStorage.cityCount, 0);
                    else
                        NPOintMutationTSP(inputchromosome[gen, i], out outputchromosome[gen, i], out  mutChormosome[gen, i], DataStorage.cityCount, 1);
                }

                for (int i = selectedvalues; i < DataStorage.initialPopCount; i++)
                    mutChormosome[gen, i] = "Nil";
            }
        }

        // ----------------------------------------------------------------------------------------------------
        //                                      Common to both modules
        // ----------------------------------------------------------------------------------------------------

        public static void UpdateTableValue(ref DataTable mainTable)
        {
            // Making sure the table is cleared before adding new values
            mainTable.Clear();

            int gen = TSPTableAndGraph.genIndex;

            if (DataStorage.isTSP)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    mainTable.Rows.Add((i + 1).ToString(), offspringBefore[gen, i], mutationChromosome[gen, i], offspringAfter[gen, i], fitnessVal[gen, i].ToString());
            }
            else
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    mainTable.Rows.Add((i + 1).ToString(), offspringBefore[gen, i], mutationChromosome[gen, i], offspringAfter[gen, i], xVal[gen, i].ToString(), fitnessVal[gen, i].ToString());
            }
        }
    }
}

