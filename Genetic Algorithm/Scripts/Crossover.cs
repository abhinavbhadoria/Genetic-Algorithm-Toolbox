using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Crossover
    {
        static Random rnd = new Random();

        static string[,] matingPool;
        static string[,] offspring;
        static string[,] crossoverPoint;
        static int[,] updatedXVal;
        static int[,] fitnessVal;

        public static DataTable InitializeTable()
        {
            DataTable table = new DataTable();

            if (DataStorage.isTSP)
            {
                table.Columns.Add("StringNo", typeof(string));
                table.Columns.Add("MatingPool", typeof(string));
                table.Columns.Add("CrossoverPoint", typeof(string));
                table.Columns.Add("Offspring", typeof(string));
                table.Columns.Add("Fitness", typeof(string));
                for (int i = 0; i < 4; i++)
                    table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            else
            {
                table.Columns.Add("StringNo", typeof(string));
                table.Columns.Add("MatingPool", typeof(string));
                table.Columns.Add("CrossoverPoint", typeof(string));
                table.Columns.Add("Offspring", typeof(string));
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

        public static int[,] DoCrossover(int[,] intialChromosome, ref DataTable mainTable)
        {
            matingPool = new string[4, DataStorage.initialPopCount];
            crossoverPoint = new string[4, DataStorage.initialPopCount];
            offspring = new string[4, DataStorage.initialPopCount];
            updatedXVal = new int[4, DataStorage.initialPopCount];
            fitnessVal = new int[4, DataStorage.initialPopCount];

            // Chromosomes that are selected for crossover
            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    matingPool[gen, i] = Utility.DecToBin(intialChromosome[gen, i]);
            }

            PerformCrossoverRateFunctionMaximize(DataStorage.crossoverRate, ref matingPool, ref offspring, ref crossoverPoint);

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    updatedXVal[gen, i] = Utility.BinToDec(offspring[gen, i]);
                    fitnessVal[gen, i] = FunctionParser.calculate(DataStorage.fitnessFunction, updatedXVal[gen, i]);
                }
            }

            // Updating the crosover table
            UpdateTableValue(ref mainTable);

            return updatedXVal;
        }
        public static void PerformCrossoverRateFunctionMaximize(int rate, ref string[,] inputchromosome, ref string[,] outputchromosome, ref string[,] crossPoint)
        {
            for (int gen = 0; gen < 4; gen++)
            {
                int length = inputchromosome.GetLength(1);
                int[] tempFitness = new int[length];
                string[] tempChromosome = new string[length];

                // Converting the chromosomes into there fitnessValue
                for (int i = 0; i < length; i++)
                    tempFitness[i] = FunctionParser.calculate(DataStorage.fitnessFunction, Utility.BinToDec(inputchromosome[gen, i]));

                // Sorting chromosomes based on their fitness level and also keeping track of thier chromosomes
                Utility.SortChromosomes(ref tempFitness, ref tempChromosome);

                // Initially, inputChomosomes and outputChromosomes are same and sorted based in thier fitness value
                for (int i = 0; i < length; i++)
                    inputchromosome[gen, i] = outputchromosome[gen, i] = tempChromosome[i];

                // selectedValues determines how many chromosomes will undergo crossover
                int selectedvalues = (int)((rate / 100f) * length);
                if ((selectedvalues % 2) == 1)
                    selectedvalues--;

                // Only first selectedValues number of chromsomes undergo crossover
                int chromosomeLength = Utility.CountMaxBits(DataStorage.UpperBound);
                for (int i = 0; i < selectedvalues; i += 2)
                {
                    if (DataStorage.crossoverType == DataStorage.crossoverSchemes[0])
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = SinglePointCrossoverFunctionMaximize(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1], chromosomeLength);
                    else
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = TwoPointCrossoverFunctionMaximize(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1], chromosomeLength);
                }

                // For non-crossovered chromosomes, their crossoverPoint is nill
                for (int i = selectedvalues; i < DataStorage.initialPopCount; i++)
                    crossPoint[gen, i] = "Nil";
            }
        }
        public static string SinglePointCrossoverFunctionMaximize(string[] str, out string offspring1, out string offspring2, int NoOfBits)
        {
            string temp1, temp2;
            string[] crossoverstring = new string[2];
            int crossoverpoint = rnd.Next(1, NoOfBits);
            int leftorright = rnd.Next(0, 2);
            if (leftorright == 0)
            {
                temp1 = str[0].Substring(0, crossoverpoint);
                temp2 = str[1].Substring(0, crossoverpoint);
                crossoverstring[0] = ReplaceAt(str[0], 0, crossoverpoint, temp2);
                crossoverstring[1] = ReplaceAt(str[1], 0, crossoverpoint, temp1);
            }
            else
            {
                temp1 = str[0].Substring(crossoverpoint, (NoOfBits - crossoverpoint));
                temp2 = str[1].Substring(crossoverpoint, (NoOfBits - crossoverpoint));
                crossoverstring[0] = ReplaceAt(str[0], crossoverpoint, (NoOfBits - crossoverpoint), temp2);
                crossoverstring[1] = ReplaceAt(str[1], crossoverpoint, (NoOfBits - crossoverpoint), temp1);
            }

            offspring1 = crossoverstring[0];
            offspring2 = crossoverstring[1];
            return crossoverpoint.ToString();
        }
        public static string TwoPointCrossoverFunctionMaximize(string[] str, out string offspring1, out string offspring2, int NoOfBits)
        {
            string temp1, temp2;
            int tempp;
            string[] crossoverstring = new string[2];
            int crossoverpoint1 = rnd.Next(1, NoOfBits);
            int crossoverpoint2 = rnd.Next(1, NoOfBits);
            if (crossoverpoint1 > crossoverpoint2)
            {
                tempp = crossoverpoint1;
                crossoverpoint1 = crossoverpoint2;
                crossoverpoint2 = tempp;
            }
            temp1 = str[0].Substring(crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1));
            temp2 = str[1].Substring(crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1));
            crossoverstring[0] = ReplaceAt(str[0], crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1), temp2);
            crossoverstring[1] = ReplaceAt(str[1], crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1), temp1);

            offspring1 = crossoverstring[0];
            offspring2 = crossoverstring[1];
            return (crossoverpoint1.ToString() + ", " + crossoverpoint2.ToString());
        }

        // ----------------------------------------------------------------------------------------------------
        //                                      TSP related functions
        // ----------------------------------------------------------------------------------------------------

        public static string[,] DoCrossover(string[,] initialPath, ref DataTable mainTable)
        {
            matingPool = new string[4, DataStorage.initialPopCount];
            crossoverPoint = new string[4, DataStorage.initialPopCount];
            offspring = new string[4, DataStorage.initialPopCount];
            fitnessVal = new int[4, DataStorage.initialPopCount];

            // Chromosomes that are selected for crossover
            matingPool = initialPath;

            PerformCrossoverRateTSP(DataStorage.crossoverRate, ref matingPool, ref offspring, ref crossoverPoint);

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    fitnessVal[gen, i] = Utility.PathFitnessCalculator(offspring[gen, i], DataStorage.distanceGraph);
            }

            // Updating the crosover table
            UpdateTableValue(ref mainTable);

            return offspring;
        }
        public static void PerformCrossoverRateTSP(int rate, ref string[,] inputchromosome, ref string[,] outputchromosome, ref string[,] crossPoint)
        {
            // selectedValues determines how many chromosomes will undergo crossover
            int selectedvalues = (int)((rate / 100f) * DataStorage.initialPopCount);
            if ((selectedvalues % 2) == 1)
                selectedvalues--;

            for (int gen = 0; gen < 4; gen++)
            {
                int length = inputchromosome.GetLength(1);
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

                // Only first selectedValues number of chromsomes undergo crossover
                for (int i = 0; i < selectedvalues; i += 2)
                {
                    if (DataStorage.crossoverType == DataStorage.crossoverSchemes[0])
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = SinglePointCrossoverTSP(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1]);
                    else
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = TwoPointCrossoverTSP(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1]);
                }

                // For non-crossovered chromosomes, their crossoverPoint is nill
                for (int i = selectedvalues; i < DataStorage.initialPopCount; i++)
                    crossPoint[gen, i] = "Nil";
            }
        }
        public static string MakeGood(string crossstring, int start, int end)
        {
            int[] occ = new int[200];
            char[] str = crossstring.ToCharArray();

            for (int i = 0; i < crossstring.Length; i++)
            {
                int index = (int)(str[i] - 'A');
                occ[index]++;
            }

            for (int i = start; i < end; i++)
            {
                if (occ[(int)(str[i] - 'A')] > 1)
                {
                    occ[(int)(str[i] - 'A')]--;
                    for (int j = 0; j < crossstring.Length; j++)
                    {
                        if (occ[j] == 0)
                        {
                            occ[j]++;
                            str[i] = (char)(j + 65);
                            break;
                        }
                    }
                }
            }
            string ans = new string(str);
            return ans;
        }
        public static string SinglePointCrossoverTSP(string[] str, out string offSpring1, out string offSpring2)
        {
            string temp1, temp2;
            int length = str[0].Length;

            string crossoverstring1, crossoverstring2;
            int crossoverpoint = rnd.Next(1, length - 1);
            int leftorright = rnd.Next(0, 2);

            if (leftorright == 0)
            {
                temp1 = str[0].Substring(0, crossoverpoint);
                temp2 = str[1].Substring(0, crossoverpoint);
                crossoverstring1 = ReplaceAt(str[0], 0, crossoverpoint, temp2);
                crossoverstring2 = ReplaceAt(str[1], 0, crossoverpoint, temp1);
                crossoverstring1 = MakeGood(crossoverstring1, crossoverpoint, length);
                crossoverstring2 = MakeGood(crossoverstring2, crossoverpoint, length);
            }
            else
            {
                temp1 = str[0].Substring(crossoverpoint, (length - crossoverpoint));
                temp2 = str[1].Substring(crossoverpoint, (length - crossoverpoint));
                crossoverstring1 = ReplaceAt(str[0], crossoverpoint, (length - crossoverpoint), temp2);
                crossoverstring2 = ReplaceAt(str[1], crossoverpoint, (length - crossoverpoint), temp1);
                crossoverstring1 = MakeGood(crossoverstring1, 0, crossoverpoint);
                crossoverstring2 = MakeGood(crossoverstring2, 0, crossoverpoint);
            }

            offSpring1 = crossoverstring1;
            offSpring2 = crossoverstring2;

            return crossoverpoint.ToString();
        }
        public static string TwoPointCrossoverTSP(string[] str, out string offSpring1, out string offSpring2)
        {
            string temp1, temp2;
            int length = str[0].Length;
            string crossoverstring1, crossoverstring2;
            int crossoverpoint1 = rnd.Next(1, length - 1);
            int crossoverpoint2 = rnd.Next(1, length - 1);

            // Making sure crossoverPoint1 is less than crossoverPoint2
            crossoverpoint1 = Math.Min(crossoverpoint1, crossoverpoint2);
            crossoverpoint2 = Math.Max(crossoverpoint1, crossoverpoint2);

            temp1 = str[0].Substring(crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1));
            temp2 = str[1].Substring(crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1));
            crossoverstring1 = ReplaceAt(str[0], crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1), temp2);
            crossoverstring2 = ReplaceAt(str[1], crossoverpoint1, (Math.Abs(crossoverpoint1 - crossoverpoint2) + 1), temp1);
            crossoverstring1 = MakeGood(crossoverstring1, 0, crossoverpoint1);
            crossoverstring1 = MakeGood(crossoverstring1, crossoverpoint2 + 1, length);
            crossoverstring2 = MakeGood(crossoverstring2, 0, crossoverpoint1);
            crossoverstring2 = MakeGood(crossoverstring2, crossoverpoint2 + 1, length);

            offSpring1 = crossoverstring1;
            offSpring2 = crossoverstring2;

            return crossoverpoint1.ToString() + ", " + crossoverpoint2.ToString();
        }

        // ----------------------------------------------------------------------------------------------------
        //                                      Common to both modules
        // ----------------------------------------------------------------------------------------------------

        public static string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }
        public static void UpdateTableValue(ref DataTable mainTable)
        {
            // Making sure the table is cleared before adding new values
            mainTable.Clear();

            int genIndex = TSPTableAndGraph.genIndex;

            if (DataStorage.isTSP)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    mainTable.Rows.Add((i + 1).ToString(), matingPool[genIndex, i], crossoverPoint[genIndex, i].ToString(), offspring[genIndex, i], fitnessVal[genIndex, i].ToString());
            }
            else
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    mainTable.Rows.Add((i + 1).ToString(), matingPool[genIndex, i], crossoverPoint[genIndex, i].ToString(), offspring[genIndex, i], updatedXVal[genIndex, i].ToString(), fitnessVal[genIndex, i].ToString());
            }
        }
    }
}