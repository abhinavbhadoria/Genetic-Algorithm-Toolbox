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
    public partial class TSPGraphInput : Form
    {
        Random rnd = new Random();

        public TSPGraphInput()
        {
            InitializeComponent();
        }

        private void TSPGraphInput_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < DataStorage.cityCount; i++)
                table.Columns.Add((Convert.ToChar(65 + i).ToString()), typeof(string));

            for (int i = 0; i < DataStorage.cityCount; i++)
                table.Rows.Add();

            DistanceMatrixDGV.DataSource = table;

            foreach (DataGridViewRow row in DistanceMatrixDGV.Rows)
                row.HeaderCell.Value = (Convert.ToChar(row.Index + 65)).ToString();

            AdjustForm();
        }

        private void ProccedBTN_Click(object sender, EventArgs e)
        {
            int[,] graph = new int[DataStorage.cityCount, DataStorage.cityCount];

            for (int i = 0; i < DataStorage.cityCount; i++)
            {
                for (int j = 0; j < DataStorage.cityCount; j++)
                {
                    int temp = 0;
                    temp = int.TryParse(DistanceMatrixDGV.Rows[i].Cells[j].Value.ToString(), out temp) ? temp : 0;
                    graph[i, j] = temp;
                }
            }

            DataStorage.distanceGraph = graph;

            Form tspTableAndGraphForm = new TSPTableAndGraph();
            tspTableAndGraphForm.Show();
            //  this.Close();
        }

        private void RandomFillLB_Click(object sender, EventArgs e)
        {
            int[,] randomData = new int[DataStorage.cityCount, DataStorage.cityCount];

            for (int i = 0; i < DataStorage.cityCount; i++)
            {
                for (int j = 0; j < DataStorage.cityCount; j++)
                    randomData[i, j] = (i == j) ? 0 : rnd.Next(1, 10);
            }

            DataStorage.distanceGraph = randomData;
            DataTable graphTable = DistanceMatrixDGV.DataSource as DataTable;
            graphTable.Clear();
            DataRow graphTableRow;
            for (int i = 0; i < DataStorage.cityCount; i++)
            {
                graphTableRow = graphTable.NewRow();
                for (int j = 0; j < DataStorage.cityCount; j++)
                    graphTableRow[j] = randomData[i, j].ToString();
                graphTable.Rows.Add(graphTableRow);
            }

            foreach (DataGridViewRow row in DistanceMatrixDGV.Rows)
                row.HeaderCell.Value = (Convert.ToChar(row.Index + 65)).ToString();
        }

        private void AdjustForm()
        {
            DistanceMatrixDGV.Height = DistanceMatrixDGV.Width = 56 * DataStorage.cityCount;
        }
    }
}
