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
    public partial class TSPTableAndGraph : Form
    {
        public static int genIndex;
        private int generationCtr = 0;
        private Random rnd = new Random();

        DataTable mainSelectionTable;
        DataTable additionalSelectionTable;
        DataTable crossOverTable;
        DataTable mutationTable;

        private string[,] mutatedPath;
        public static int[,] minimaSaved;
        public static string[,] minimaPathSaved;
        private bool initialLoad = true;

        public TSPTableAndGraph()
        {
            InitializeComponent();
        }

        private void TSPTableAndGraph_Load(object sender, EventArgs e)
        {
            UpdateGenIndex(DataStorage.selectionType);

            // SelectionSchemeChoose combobox
            this.SelectionSchemeChooseCB.Items.Add("Roulette wheel selection");
            this.SelectionSchemeChooseCB.Items.Add("Random selection");
            this.SelectionSchemeChooseCB.Items.Add("Rank selection");
            this.SelectionSchemeChooseCB.Items.Add("Tournament selection");

            // Selection tables
            SelectDGV.DataSource = Selection.InitializeTable();
            AdditionalSelectDGV.DataSource = Selection.InitializeAdditionalTable();
            this.SelectionTypeLB.Text = DataStorage.selectionType;
            mainSelectionTable = SelectDGV.DataSource as DataTable;
            additionalSelectionTable = AdditionalSelectDGV.DataSource as DataTable;
            toolTip1.SetToolTip(SelectionTypeLB, DataStorage.selectionToolTip[genIndex]);

            // Crossover tables
            CrossDGV.DataSource = Crossover.InitializeTable();
            this.CrossoverTypeLB.Text = DataStorage.crossoverType;
            this.CrosoverRateLB.Text = "Crossover rate: " + DataStorage.crossoverRate.ToString() + "%";
            crossOverTable = CrossDGV.DataSource as DataTable;
            toolTip1.SetToolTip(CrossoverTypeLB, DataStorage.GetCrossoverToolTip());

            // Mutation tables
            MutDGV.DataSource = Mutation.InitializeTable();
            this.MutationTypeLB.Text = DataStorage.mutationType;
            this.MutationRateLB.Text = "Mutation rate: " + DataStorage.mutationRate.ToString() + "%";
            mutationTable = MutDGV.DataSource as DataTable;
            toolTip1.SetToolTip(MutationTypeLB, DataStorage.GetMutationToolTip());

            // Initializing the selection scheme choose combobox
            this.SelectionSchemeChooseCB.Text = DataStorage.selectionType;

            // Matrix containing the minimum distance from each generation for each selection scheme
            minimaSaved = new int[DataStorage.generationCount, 4];
            minimaPathSaved = new string[DataStorage.generationCount, 4];

            // What are we waiting for, set start the games
            ConductGeneticAlgorithm();
        }

        private void ConductGeneticAlgorithm()
        {
            string[,] initialPath = new string[4, DataStorage.initialPopCount];
            if (generationCtr == 0)
            {
                for (int i = 0; i < DataStorage.initialPopCount; i++)
                    initialPath[0, i] = initialPath[1, i] = initialPath[2, i] = initialPath[3, i] = Utility.GetRandomPath(DataStorage.cityCount);
            }
            else
                initialPath = mutatedPath;

            // Performing selection
            string[,] selectedpath = Selection.DoSelection(initialPath, ref mainSelectionTable, ref additionalSelectionTable);

            // Performing crossover
            string[,] crossOveredValue = Crossover.DoCrossover(selectedpath, ref crossOverTable);

            // Performing mutation
            int[] minima = new int[4];
            string[] minimaPath = new string[4];
            mutatedPath = Mutation.DoMutation(crossOveredValue, ref mutationTable, ref minima, ref minimaPath);

            for (int gen = 0; gen < 4; gen++)
            {
                minimaSaved[generationCtr, gen] = minima[gen];
                minimaPathSaved[generationCtr, gen] = minimaPath[gen];
            }

            GenerationTB.Text = (generationCtr + 1).ToString();
            MinimaTB.Text = minima[genIndex].ToString();
            MinimaPathTB.Text = minimaPath[genIndex].ToString();

            for (int gen = 0; gen < 4; gen++)
                DistanceChart.Series[DataStorage.selectionSchemes[gen]].Points.AddXY((generationCtr + 1), minimaSaved[generationCtr, gen]);

            generationCtr++;

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
            MinimaTB.Text = minimaSaved[generationCtr - 1, genIndex].ToString();
            MinimaPathTB.Text = minimaPathSaved[generationCtr - 1, genIndex].ToString();

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
