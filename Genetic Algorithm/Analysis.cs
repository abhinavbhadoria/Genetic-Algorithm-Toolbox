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
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Generation", typeof(string));
            table.Columns.Add("Population count", typeof(string));
            table.Columns.Add("Maxima", typeof(string));
            table.Columns.Add("Time", typeof(string));

            for (int i = 0; i < 4; i++)
            {
                int maxima = int.MinValue;
                for (int j = 0; j < DataStorage.generationCount; j++)
                {
                    if (TableAndGraph.maximaSaved[j, i] > maxima)
                        maxima = TableAndGraph.maximaSaved[j, i];
                }

                table.Rows.Add(DataStorage.generationCount.ToString(), DataStorage.initialPopCount.ToString(), maxima.ToString(), "NaN");
            }

            AnalysisDGV.DataSource = table;
        }
    }
}
