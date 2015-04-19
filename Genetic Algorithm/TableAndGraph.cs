using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class TableAndGraph : Form
    {
        public static int genIndex;
        private bool isConductingGA = false;
        private int generationCtr = 0;
        private Random rnd = new Random();

        DataTable mainSelectionTable;
        DataTable additionalSelectionTable;
        DataTable crossOverTable;
        DataTable mutationTable;

        private int[,] mutatedChromosomes;
        public static int[,] maximaSaved;
        private bool initialLoad = true;

        public TableAndGraph()
        {
            InitializeComponent();
        }

        private void TableAndGraph_Load(object sender, EventArgs e)
        {
            UpdateGenIndex(DataStorage.selectionType);

            // SelectionSchemeChoose combobox
            SelectionSchemeChooseCB.Items.Add("Roulette wheel selection");
            SelectionSchemeChooseCB.Items.Add("Random selection");
            SelectionSchemeChooseCB.Items.Add("Rank selection");
            SelectionSchemeChooseCB.Items.Add("Tournament selection");

            ////// Selection tables
            SelectionDGV.DataSource = Selection.InitializeTable();
            SelectionDGV.Columns[0].Width = 50;
            SelectionAdditionalDGV.DataSource = Selection.InitializeAdditionalTable();
            SelectionTypeLB.Text = DataStorage.selectionType;
            mainSelectionTable = SelectionDGV.DataSource as DataTable;
            additionalSelectionTable = SelectionAdditionalDGV.DataSource as DataTable;
            toolTip1.SetToolTip(SelectionTypeLB, DataStorage.selectionToolTip[genIndex]);


            // Crossover tables
            CrossoverDGV.DataSource = Crossover.InitializeTable();
            CrossoverDGV.Columns[0].Width = 50;
            CrossoverTypeLB.Text = DataStorage.crossoverType;
            crossOverTable = CrossoverDGV.DataSource as DataTable;
            toolTip1.SetToolTip(CrossoverTypeLB, DataStorage.GetCrossoverToolTip());

            // Mutation tables
            MutationDGV.DataSource = Mutation.InitializeTable();
            MutationDGV.Columns[0].Width = 50;
            MutationTypeLB.Text = DataStorage.mutationType;
            mutationTable = MutationDGV.DataSource as DataTable;
            toolTip1.SetToolTip(MutationTypeLB, DataStorage.GetMutationToolTip());

            ShowFitnessFunLB.Text = DataStorage.fitnessFunction;
            SelectionSchemeChooseCB.Text = DataStorage.selectionType;

            maximaSaved = new int[DataStorage.generationCount, 4];

            ConductGeneticAlgorithm();
        }

        private void ConductGeneticAlgorithm()
        {
            if (isConductingGA)
                return;

            isConductingGA = true;

            int[,] xVal = new int[4, DataStorage.initialPopCount];
            if (generationCtr == 0)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    xVal[0, i] = xVal[1, i] = xVal[2, i] = xVal[3, i] = rnd.Next(DataStorage.lowerBound, DataStorage.UpperBound);
            }
            else
                xVal = mutatedChromosomes;

            // Performing selection
            int[,] selectedXVal = Selection.DoSelection(xVal, ref mainSelectionTable, ref additionalSelectionTable);

            // Performing crossover
            int[,] crossOveredValue = Crossover.DoCrossover(selectedXVal, ref crossOverTable);

            // Performing mutation
            int[] maxima = new int[4];
            mutatedChromosomes = Mutation.DoMutation(crossOveredValue, ref mutationTable, ref maxima);

            for (int gen = 0; gen < 4; gen++)
                maximaSaved[generationCtr, gen] = maxima[gen];

            GenerationTB.Text = (generationCtr + 1).ToString();
            MaximaTB.Text = maxima[genIndex].ToString();

            for (int gen = 0; gen < 4; gen++)
                GenVsMaximaChart.Series[DataStorage.selectionSchemes[gen]].Points.AddXY((generationCtr + 1), DataStorage.UpperBound - maximaSaved[generationCtr, gen]);

            generationCtr++;
            isConductingGA = false;

            if (generationCtr == DataStorage.generationCount)
            {
                Form analysis = new Analysis();
                analysis.Show();

            }
        }

        private void LoadNextGenButton_Click(object sender, EventArgs e)
        {
            if (generationCtr < DataStorage.generationCount)
                ConductGeneticAlgorithm();
        }

        private void AutomateGA_Click(object sender, EventArgs e)
        {
            for (int i = generationCtr; i < DataStorage.generationCount; i++)
                ConductGeneticAlgorithm();
        }

        private void UpdateTableAndGraphValues()
        {
            SelectionTypeLB.Text = DataStorage.selectionSchemes[genIndex];
            MaximaTB.Text = maximaSaved[generationCtr - 1, genIndex].ToString();

            Selection.UpdateTableValue(ref mainSelectionTable, ref additionalSelectionTable);
            Crossover.UpdateTableValue(ref crossOverTable);
            Mutation.UpdateTableValue(ref mutationTable);

            toolTip1.SetToolTip(SelectionTypeLB, DataStorage.selectionToolTip[genIndex]);
        }

        private void UpdateGenIndex(string selectionType)
        {
            for (int i = 0; i < 4; i++)
            {
                if (selectionType == DataStorage.selectionSchemes[i])
                {
                    genIndex = i;
                    break;
                }
            }

        }

        private void SelectionSchemeChooseCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialLoad)
            {
                initialLoad = false;
                return;
            }

            UpdateGenIndex(SelectionSchemeChooseCB.Text);
            UpdateTableAndGraphValues();
        }


    }
}
