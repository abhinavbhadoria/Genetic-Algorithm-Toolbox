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
    public partial class UserInput : Form
    {
        const int BACKSPACE = 8;
        const int ZERO = 48;
        const int NINE = 57;
        const int CARET = 94;
        const int PLUS = 43;
        const int MINUS = 45;

        int maxUpperLimit = 100, maxGenCount = 100, maxInitialPop = 100;

        public UserInput()
        {
            InitializeComponent();
        }

        private void UserInput_Load(object sender, EventArgs e)
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

        private void NumOfVarTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LowerBoundTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyvalue = e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
            {
                string newtext = LowerBoundTB.Text + e.KeyChar;
                int lowLimit;
                if (int.TryParse(newtext, out lowLimit))
                {
                    if (lowLimit != 0)
                    {
                        LowerBoundTB.Text = 0.ToString();
                        e.Handled = true;
                    }
                }
                return;
            }

            e.Handled = true;
        }

        private void UpperBoundTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyvalue = e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
            {
                string newtext = UpperBoundTB.Text + e.KeyChar;
                int upLimit;
                if (int.TryParse(newtext, out upLimit))
                {
                    if (upLimit > maxUpperLimit || upLimit < 0)
                    {
                        UpperBoundTB.Text = maxUpperLimit.ToString();
                        e.Handled = true;
                    }
                }
                return;
            }

            e.Handled = true;
        }


        private void InitialPopCountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyvalue = e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
            {
                string newtext = InitialPopCountTB.Text + e.KeyChar;
                int popCount;
                if (int.TryParse(newtext, out popCount))
                {
                    if (popCount > maxInitialPop)
                    {
                        InitialPopCountTB.Text = maxInitialPop.ToString();
                        e.Handled = true;
                    }
                }
                return;
            }

            e.Handled = true;
        }

        private void InitialPopCountTB_Leave(object sender, EventArgs e)
        {
            string newtext = InitialPopCountTB.Text;
            int popCount;
            if (int.TryParse(newtext, out popCount))
            {
                if (popCount % 2 != 0)
                {
                    popCount++;
                    InitialPopCountTB.Text = popCount.ToString();
                }
            }
        }

        private void GenerationCountTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            int keyvalue = e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE)))
            {
                string newtext = GenerationCountTB.Text + e.KeyChar;
                int genCount;
                if (int.TryParse(newtext, out genCount))
                {
                    if (genCount > maxGenCount)
                    {
                        GenerationCountTB.Text = maxGenCount.ToString();
                        e.Handled = true;
                    }
                }
                return;
            }

            e.Handled = true;
        }

        private void FitnessFuncTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyvalue = e.KeyChar;

            NumOfVarTB.Text = "1";

            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE)) || (char.ToUpper(e.KeyChar) == (char)Keys.X) ||
                (keyvalue == CARET) || (keyvalue == PLUS) || (keyvalue == MINUS))
                return;

            e.Handled = true;
        }

        private void LoadTableFormButton_Click(object sender, EventArgs e)
        {
            if (!IsFormFilledCompletely())
                return;

            DataStorage.SaveData(FitnessFuncTB.Text, NumOfVarTB.Text, LowerBoundTB.Text, UpperBoundTB.Text, InitialPopCountTB.Text, GenerationCountTB.Text, SelectionCB.Text, CrossoverCB.Text, MutationCB.Text, CrossoverTrackBar.Value, MutationTrackBar.Value);
            Form tableAndGraphForm = new TableAndGraph();
            tableAndGraphForm.Show();
        }

        private bool IsFormFilledCompletely()
        {
            if (string.IsNullOrEmpty(FitnessFuncTB.Text) || string.IsNullOrEmpty(NumOfVarTB.Text) || string.IsNullOrEmpty(LowerBoundTB.Text)
             || string.IsNullOrEmpty(UpperBoundTB.Text) || string.IsNullOrEmpty(InitialPopCountTB.Text) || string.IsNullOrEmpty(GenerationCountTB.Text)
             || string.IsNullOrEmpty(SelectionCB.Text) || string.IsNullOrEmpty(CrossoverCB.Text)
             || (string.IsNullOrEmpty(MutationCB.Text)))
                return false;
            return true;
        }

        private void CrossoverTrackBar_ValueChanged(object sender, EventArgs e)
        {
            CrossoverRateData.Text = CrossoverTrackBar.Value.ToString() + "%";
        }

        private void MutationTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MutationRateData.Text = MutationTrackBar.Value.ToString() + "%";
        }
    }
}
