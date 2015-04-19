using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            table.Columns.Add("StringNo", typeof(string));
            table.Columns.Add("MatingPool", typeof(string));
            table.Columns.Add("CrossoverPoint", typeof(string));
            table.Columns.Add("Offspring", typeof(string));
            table.Columns.Add("x-value", typeof(string));
            table.Columns.Add("Fitness", typeof(string));

            for (int i = 0; i < 4; i++)
                table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            return table;
        }

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

            PerformCrossoverRate(DataStorage.crossoverRate, ref matingPool, ref offspring, ref crossoverPoint);

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

        public static void UpdateTableValue(ref DataTable mainTable)
        {
            // Making sure the table is cleared before adding new values
            mainTable.Clear();

            int genIndex = TableAndGraph.genIndex;

            for (int i = 0; i < DataStorage.initialPopCount; i++)
                mainTable.Rows.Add((i + 1).ToString(), matingPool[genIndex, i], crossoverPoint[genIndex, i].ToString(), offspring[genIndex, i], updatedXVal[genIndex, i].ToString(), fitnessVal[genIndex, i].ToString());
        }

        public static string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }

        public static string PerformCrossoverSinglePoint(string[] str, out string offspring1, out string offspring2, int NoOfBits)
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

        public static string PerformCrossoverMultiplePoint(string[] str, out string offspring1, out string offspring2, int NoOfBits)
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

        public static void PerformCrossoverRate(int rate, ref string[,] inputchromosome, ref string[,] outputchromosome, ref string[,] crossPoint)
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
                    inputchromosome[gen, i] = Utility.DecToBin(temp[i]);

                for (int i = 0; i < length; i++)
                    outputchromosome[gen, i] = Utility.DecToBin(temp[i]);

                for (int i = 0; i < selectedvalues; i += 2)
                {
                    if (DataStorage.crossoverType == DataStorage.crossoverSchemes[0])
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = PerformCrossoverSinglePoint(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1], Utility.CountMaxBits(DataStorage.UpperBound));
                    else
                        crossPoint[gen, i] = crossPoint[gen, i + 1] = PerformCrossoverMultiplePoint(new string[] { inputchromosome[gen, i], inputchromosome[gen, i + 1] }, out outputchromosome[gen, i], out  outputchromosome[gen, i + 1], Utility.CountMaxBits(DataStorage.UpperBound));
                }

                for (int i = selectedvalues; i < DataStorage.initialPopCount; i++)
                    crossPoint[gen, i] = "Nil";
            }
        }
    }
}