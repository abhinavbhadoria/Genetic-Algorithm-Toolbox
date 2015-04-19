using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Selection
    {
        private static Random rnd = new Random();

        // Variables for mainTable
        static int[,] xValue;
        static int[,] fitnessVal;
        static double[,] prob;
        static double[,] probPercent;
        static double[,] expectedCount;
        static int[,] actualCount;
        // Variables for additionalTable
        static int[,] additionalTableFitness;
        static double[,] additionalTableProb;
        static double[,] additionalTableProbPercent;
        static double[,] additionalTableExpectedCount;
        static int[,] additionalTableActualCount;

        static int[,] selectedXVal;

        public static DataTable InitializeTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("StringNo", typeof(string));
            table.Columns.Add("InitialPopulation", typeof(string));
            table.Columns.Add("x-value", typeof(string));
            table.Columns.Add("Fitness", typeof(string));
            table.Columns.Add("Probability", typeof(string));
            table.Columns.Add("PercentageProb", typeof(string));
            table.Columns.Add("ExpectedCount", typeof(string));
            table.Columns.Add("ActualCount", typeof(string));

            for (int i = 0; i < 4; i++)
                table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            return table;
        }

        public static DataTable InitializeAdditionalTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Fitness", typeof(string));
            table.Columns.Add("Probability", typeof(string));
            table.Columns.Add("PercentageProb", typeof(string));
            table.Columns.Add("ExpectedCount", typeof(string));
            table.Columns.Add("ActualCount", typeof(string));

            for (int i = 0; i < 3; i++)
                table.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            return table;
        }

        public static int[,] DoSelection(int[,] xVal, ref DataTable mainTable, ref DataTable additionalTable)
        {
            PerformInitialCalulation(xVal, ref mainTable, ref additionalTable);

            selectedXVal = new int[4, DataStorage.initialPopCount];

            RouletteWheel(xVal);
            RandomSelection(xVal);
            RankSelection(xVal);
            TournamentSelection(xVal);

            UpdateTableValue(ref mainTable, ref additionalTable);

            return selectedXVal;
        }

        private static void RouletteWheel(int[,] xVal)
        {
            // Determing which chromosomes to be selected for later processes
            int index = 0, gen = 0;
            for (int i = 0; i < DataStorage.initialPopCount; i++)
            {
                if (actualCount[gen, i] != 0)
                {
                    // Copying the xvalues actualCount number of times
                    for (int j = 0; j < actualCount[gen, i]; j++)
                    {
                        // Failsafe to limit the number of selected chromosome
                        if (index == DataStorage.initialPopCount) return;
                        selectedXVal[gen, index++] = xVal[gen, i];
                    }
                }
            }

            // Making sure atleast 4 chromosomes are always selected
            for (int i = index; i < DataStorage.initialPopCount; i++)
                selectedXVal[gen, i] = selectedXVal[gen, 0];
        }

        public static void RandomSelection(int[,] xVal)
        {
            // Determing which chromosomes to be selected for later processes
            int gen = 1;
            for (int i = 0; i < DataStorage.initialPopCount; i++)
            {
                int number = rnd.Next(DataStorage.initialPopCount - 1);
                selectedXVal[gen, i] = xVal[gen, number];
            }
        }

        public static void RankSelection(int[,] xVal)
        {
            // Determing which chromosomes to be selected for later processes
            int gen = 2;

            double max = -1, min = 1000;
            int posmax = 0, posmin = 0;
            for (int i = 0; i < DataStorage.initialPopCount; i++)
            {
                if (max < probPercent[gen, i])
                {
                    max = probPercent[gen, i];
                    posmax = i;
                }
                else if (min > probPercent[gen, i])
                {
                    max = probPercent[gen, i];
                    posmin = i;
                }
            }

            for (int i = 0; i < DataStorage.initialPopCount; i++)
            {
                if (i == posmin)
                    selectedXVal[gen, i] = xVal[gen, posmax];
                selectedXVal[gen, i] = xVal[gen, i];
            }
        }

        public static void TournamentSelection(int[,] xVal)
        {
            // Determing which chromosomes to be selected for later processes
            int gen = 3;
            int max;
            for (int i = 0; i < DataStorage.initialPopCount; i++)
            {
                int number1 = rnd.Next(DataStorage.initialPopCount - 1);
                int number2 = rnd.Next(DataStorage.initialPopCount - 1);
                while (number2 == number1)
                    number2 = rnd.Next(DataStorage.initialPopCount - 1);

                max = (probPercent[gen, number1] > probPercent[gen, number2]) ? number1 : number2;
                selectedXVal[gen, i] = xVal[gen, max];
            }
        }

        private static void PerformInitialCalulation(int[,] xVal, ref DataTable mainTable, ref DataTable additionalTable)
        {
            xValue = new int[4, DataStorage.initialPopCount];
            fitnessVal = new int[4, DataStorage.initialPopCount];
            prob = new double[4, DataStorage.initialPopCount];
            probPercent = new double[4, DataStorage.initialPopCount];
            expectedCount = new double[4, DataStorage.initialPopCount];
            actualCount = new int[4, DataStorage.initialPopCount];

            additionalTableFitness = new int[4, 3];
            additionalTableProb = new double[4, 3];
            additionalTableProbPercent = new double[4, 3];
            additionalTableExpectedCount = new double[4, 3];
            additionalTableActualCount = new int[4, 3];

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    fitnessVal[gen, i] = FunctionParser.calculate(DataStorage.fitnessFunction, xVal[gen, i]);
                    xValue[gen, i] = xVal[gen, i];
                }
            }

            int[] sumFitness = new int[DataStorage.initialPopCount];
            int[] avgFitness = new int[DataStorage.initialPopCount];
            for (int gen = 0; gen < 4; gen++)
            {
                sumFitness[gen] = Utility.GetSum(fitnessVal, gen);
                avgFitness[gen] = Utility.GetAvg(fitnessVal, gen);
            }

            for (int gen = 0; gen < 4; gen++)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                {
                    prob[gen, i] = Math.Round((double)fitnessVal[gen, i] / sumFitness[gen], 2);
                    probPercent[gen, i] = prob[gen, i] * 100;
                    expectedCount[gen, i] = Math.Round((double)fitnessVal[gen, i] / avgFitness[gen], 2);
                    actualCount[gen, i] = (int)Math.Round(expectedCount[gen, i], 0);
                }
            }

            for (int gen = 0; gen < 4; gen++)
            {
                // Calculation for data in additional selection table
                additionalTableFitness[gen, 0] = Utility.GetSum(fitnessVal, gen);
                additionalTableFitness[gen, 1] = Utility.GetAvg(fitnessVal, gen);
                additionalTableFitness[gen, 2] = Utility.GetMax(fitnessVal, gen);
                additionalTableProb[gen, 0] = Utility.GetSum(prob, gen);
                additionalTableProb[gen, 1] = Utility.GetAvg(prob, gen);
                additionalTableProb[gen, 2] = Utility.GetMax(prob, gen);
                additionalTableProbPercent[gen, 0] = Utility.GetSum(probPercent, gen);
                additionalTableProbPercent[gen, 1] = Utility.GetAvg(probPercent, gen);
                additionalTableProbPercent[gen, 2] = Utility.GetMax(probPercent, gen);
                additionalTableExpectedCount[gen, 0] = Utility.GetSum(expectedCount, gen);
                additionalTableExpectedCount[gen, 1] = Utility.GetAvg(expectedCount, gen);
                additionalTableExpectedCount[gen, 2] = Utility.GetMax(expectedCount, gen);
                additionalTableActualCount[gen, 0] = Utility.GetSum(actualCount, gen);
                additionalTableActualCount[gen, 1] = Utility.GetAvg(actualCount, gen);
                additionalTableActualCount[gen, 2] = Utility.GetMax(actualCount, gen);
            }
        }

        public static void UpdateTableValue(ref DataTable mainTable, ref DataTable additionalTable)
        {
            // Removing any previous values in the table
            mainTable.Clear();
            additionalTable.Clear();

            int genIndex = TableAndGraph.genIndex;

            // Updating SelectionMain table
            for (int i = 0; i < DataStorage.initialPopCount; i++)
                mainTable.Rows.Add((i + 1).ToString(), Utility.DecToBin(xValue[genIndex, i]), xValue[genIndex, i].ToString(), fitnessVal[genIndex, i].ToString(), prob[genIndex, i].ToString(), probPercent[genIndex, i].ToString(), expectedCount[genIndex, i].ToString(), actualCount[genIndex, i].ToString());

            // Updating SelectionAdditional table
            for (int i = 0; i < 3; i++)
                additionalTable.Rows.Add(additionalTableFitness[genIndex, i].ToString(), additionalTableProb[genIndex, i].ToString(), additionalTableProbPercent[genIndex, i].ToString(), additionalTableExpectedCount[genIndex, i].ToString(), additionalTableActualCount[genIndex, i].ToString());

        }
            }
}
