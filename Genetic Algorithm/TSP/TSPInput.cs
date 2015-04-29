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
    public partial class TSPInput : Form
    {
        public TSPInput()
        {
            InitializeComponent();
        }

        private void LoadTableFormButton_Click(object sender, EventArgs e)
        {
            //if (!IsFormFilledCompletely())
            //    return;

            DataStorage.SaveData(CityCountTB.Text, InitialPopCountTB.Text, GenerationCountTB.Text ,SelectionCB.Text, CrossoverCB.Text, MutationCB.Text, CrossoverTrackBar.Value, MutationTrackBar.Value);
            Form tspGraphInputForm = new TSPGraphInput();
            tspGraphInputForm.Show();
        }

        private void TSPInput_Load(object sender, EventArgs e)
        {
            // Selection combobox
            for (int i = 0; i < DataStorage.selectionSchemes.Length; i++)
                SelectionCB.Items.Add(DataStorage.selectionSchemes[i]);

            // Crossover combobox
            for (int i = 0; i < DataStorage.crossoverSchemes.Length; i++)
                CrossoverCB.Items.Add(DataStorage.crossoverSchemes[i]);

            // Mutation combobx
            for (int i = 0; i < DataStorage.mutationSchemes.Length; i++)
                MutationCB.Items.Add(DataStorage.mutationSchemes[i]);

            CrossoverRateData.Text = CrossoverTrackBar.Value.ToString() + "%";
            MutationRateData.Text = MutationTrackBar.Value.ToString() + "%";
        }

        private void CrossoverTrackBar_ValueChanged(object sender, EventArgs e)
        {
            CrossoverRateData.Text = CrossoverTrackBar.Value.ToString() + "%";
        }

        private void MutationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MutationRateData.Text = MutationTrackBar.Value.ToString() + "%";
        }

        private bool IsFormFilledCompletely()
        {
            if (string.IsNullOrEmpty(CityCountTB.Text) || string.IsNullOrEmpty(InitialPopCountTB.Text)
                || string.IsNullOrEmpty(SelectionCB.Text) || string.IsNullOrEmpty(CrossoverCB.Text) || (string.IsNullOrEmpty(MutationCB.Text)))
                return false;
            return true;
        }
    }
}
