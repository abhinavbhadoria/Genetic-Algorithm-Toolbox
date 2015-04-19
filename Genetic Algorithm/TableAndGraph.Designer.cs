namespace Genetic_Algorithm
{
    partial class TableAndGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SelectionDGV = new System.Windows.Forms.DataGridView();
            this.CrossoverDGV = new System.Windows.Forms.DataGridView();
            this.MutationDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionAdditionalDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenVsMaximaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerationTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaximaTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectionTypeLB = new System.Windows.Forms.Label();
            this.CrossoverTypeLB = new System.Windows.Forms.Label();
            this.MutationTypeLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowFitnessFunLB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.AutomateGA = new System.Windows.Forms.Button();
            this.SelectionSchemeChooseCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionAdditionalDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenVsMaximaChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionDGV
            // 
            this.SelectionDGV.AllowUserToResizeColumns = false;
            this.SelectionDGV.AllowUserToResizeRows = false;
            this.SelectionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionDGV.Location = new System.Drawing.Point(13, 49);
            this.SelectionDGV.Name = "SelectionDGV";
            this.SelectionDGV.RowHeadersVisible = false;
            this.SelectionDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectionDGV.Size = new System.Drawing.Size(772, 134);
            this.SelectionDGV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.SelectionDGV, "Table depecting various parameters conidered while performing selection");
            // 
            // CrossoverDGV
            // 
            this.CrossoverDGV.AllowUserToResizeColumns = false;
            this.CrossoverDGV.AllowUserToResizeRows = false;
            this.CrossoverDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrossoverDGV.Location = new System.Drawing.Point(15, 353);
            this.CrossoverDGV.Name = "CrossoverDGV";
            this.CrossoverDGV.RowHeadersVisible = false;
            this.CrossoverDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CrossoverDGV.Size = new System.Drawing.Size(573, 134);
            this.CrossoverDGV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.CrossoverDGV, "Table containing various crossover parameters");
            // 
            // MutationDGV
            // 
            this.MutationDGV.AllowUserToResizeColumns = false;
            this.MutationDGV.AllowUserToResizeRows = false;
            this.MutationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MutationDGV.Location = new System.Drawing.Point(15, 553);
            this.MutationDGV.Name = "MutationDGV";
            this.MutationDGV.RowHeadersVisible = false;
            this.MutationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MutationDGV.Size = new System.Drawing.Size(573, 134);
            this.MutationDGV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.MutationDGV, "Table containing various mutaion parameters");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crossover";
            // 
            // SelectionAdditionalDGV
            // 
            this.SelectionAdditionalDGV.AllowUserToResizeColumns = false;
            this.SelectionAdditionalDGV.AllowUserToResizeRows = false;
            this.SelectionAdditionalDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionAdditionalDGV.Location = new System.Drawing.Point(261, 189);
            this.SelectionAdditionalDGV.Name = "SelectionAdditionalDGV";
            this.SelectionAdditionalDGV.RowHeadersVisible = false;
            this.SelectionAdditionalDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectionAdditionalDGV.Size = new System.Drawing.Size(505, 113);
            this.SelectionAdditionalDGV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.SelectionAdditionalDGV, "Table containing sum, avg, max of selection parameters ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mutation";
            // 
            // GenVsMaximaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GenVsMaximaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GenVsMaximaChart.Legends.Add(legend1);
            this.GenVsMaximaChart.Location = new System.Drawing.Point(629, 353);
            this.GenVsMaximaChart.Name = "GenVsMaximaChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Roulette wheel selection";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Random selection";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Rank selection";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Tournament selection";
            this.GenVsMaximaChart.Series.Add(series1);
            this.GenVsMaximaChart.Series.Add(series2);
            this.GenVsMaximaChart.Series.Add(series3);
            this.GenVsMaximaChart.Series.Add(series4);
            this.GenVsMaximaChart.Size = new System.Drawing.Size(718, 334);
            this.GenVsMaximaChart.TabIndex = 2;
            this.GenVsMaximaChart.Text = "chart1";
            this.toolTip1.SetToolTip(this.GenVsMaximaChart, "Chart showing error vs generation. Lower the value better the result");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generation";
            // 
            // GenerationTB
            // 
            this.GenerationTB.Location = new System.Drawing.Point(117, 22);
            this.GenerationTB.Name = "GenerationTB";
            this.GenerationTB.Size = new System.Drawing.Size(100, 20);
            this.GenerationTB.TabIndex = 4;
            this.toolTip1.SetToolTip(this.GenerationTB, "How many generations have passed");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(24, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Maxima";
            // 
            // MaximaTB
            // 
            this.MaximaTB.Location = new System.Drawing.Point(117, 59);
            this.MaximaTB.Name = "MaximaTB";
            this.MaximaTB.Size = new System.Drawing.Size(100, 20);
            this.MaximaTB.TabIndex = 4;
            this.toolTip1.SetToolTip(this.MaximaTB, "Maxima of current generation. Bigger the value the better the result.");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.MaximaTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GenerationTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(825, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 105);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(196, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(196, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(196, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Maximum";
            // 
            // SelectionTypeLB
            // 
            this.SelectionTypeLB.AutoSize = true;
            this.SelectionTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionTypeLB.ForeColor = System.Drawing.Color.White;
            this.SelectionTypeLB.Location = new System.Drawing.Point(100, 20);
            this.SelectionTypeLB.Name = "SelectionTypeLB";
            this.SelectionTypeLB.Size = new System.Drawing.Size(39, 17);
            this.SelectionTypeLB.TabIndex = 1;
            this.SelectionTypeLB.Text = "asda";
            // 
            // CrossoverTypeLB
            // 
            this.CrossoverTypeLB.AutoSize = true;
            this.CrossoverTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossoverTypeLB.ForeColor = System.Drawing.Color.White;
            this.CrossoverTypeLB.Location = new System.Drawing.Point(100, 322);
            this.CrossoverTypeLB.Name = "CrossoverTypeLB";
            this.CrossoverTypeLB.Size = new System.Drawing.Size(72, 17);
            this.CrossoverTypeLB.TabIndex = 1;
            this.CrossoverTypeLB.Text = "Crossover";
            this.toolTip1.SetToolTip(this.CrossoverTypeLB, "Currently selected crossover technique");
            // 
            // MutationTypeLB
            // 
            this.MutationTypeLB.AutoSize = true;
            this.MutationTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutationTypeLB.ForeColor = System.Drawing.Color.White;
            this.MutationTypeLB.Location = new System.Drawing.Point(100, 522);
            this.MutationTypeLB.Name = "MutationTypeLB";
            this.MutationTypeLB.Size = new System.Drawing.Size(62, 17);
            this.MutationTypeLB.TabIndex = 1;
            this.MutationTypeLB.Text = "Mutation";
            this.toolTip1.SetToolTip(this.MutationTypeLB, "Currently selected mutation technique");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.ShowFitnessFunLB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(825, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 62);
            this.panel2.TabIndex = 5;
            // 
            // ShowFitnessFunLB
            // 
            this.ShowFitnessFunLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFitnessFunLB.ForeColor = System.Drawing.Color.Brown;
            this.ShowFitnessFunLB.Location = new System.Drawing.Point(143, 22);
            this.ShowFitnessFunLB.Name = "ShowFitnessFunLB";
            this.ShowFitnessFunLB.Size = new System.Drawing.Size(83, 15);
            this.ShowFitnessFunLB.TabIndex = 3;
            this.ShowFitnessFunLB.Text = "x^2+1";
            this.ShowFitnessFunLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.ShowFitnessFunLB, "Fitness function used to determine the fitness of chromosomes");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(24, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fitness Function";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(1154, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next Generation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoadNextGenButton_Click);
            // 
            // AutomateGA
            // 
            this.AutomateGA.BackColor = System.Drawing.Color.Wheat;
            this.AutomateGA.ForeColor = System.Drawing.Color.Brown;
            this.AutomateGA.Location = new System.Drawing.Point(1154, 216);
            this.AutomateGA.Name = "AutomateGA";
            this.AutomateGA.Size = new System.Drawing.Size(126, 58);
            this.AutomateGA.TabIndex = 8;
            this.AutomateGA.Text = "Automate GA";
            this.AutomateGA.UseVisualStyleBackColor = false;
            this.AutomateGA.Click += new System.EventHandler(this.AutomateGA_Click);
            // 
            // SelectionSchemeChooseCB
            // 
            this.SelectionSchemeChooseCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SelectionSchemeChooseCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectionSchemeChooseCB.FormattingEnabled = true;
            this.SelectionSchemeChooseCB.Location = new System.Drawing.Point(1056, 49);
            this.SelectionSchemeChooseCB.Name = "SelectionSchemeChooseCB";
            this.SelectionSchemeChooseCB.Size = new System.Drawing.Size(239, 21);
            this.SelectionSchemeChooseCB.TabIndex = 9;
            this.SelectionSchemeChooseCB.SelectedIndexChanged += new System.EventHandler(this.SelectionSchemeChooseCB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(887, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Choose selection scheme";
            // 
            // TableAndGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1370, 699);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SelectionSchemeChooseCB);
            this.Controls.Add(this.AutomateGA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenVsMaximaChart);
            this.Controls.Add(this.SelectionTypeLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MutationTypeLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CrossoverTypeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MutationDGV);
            this.Controls.Add(this.SelectionAdditionalDGV);
            this.Controls.Add(this.CrossoverDGV);
            this.Controls.Add(this.SelectionDGV);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TableAndGraph";
            this.Text = "TableAndGraph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TableAndGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MutationDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionAdditionalDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenVsMaximaChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectionDGV;
        private System.Windows.Forms.DataGridView CrossoverDGV;
        private System.Windows.Forms.DataGridView MutationDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SelectionAdditionalDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenVsMaximaChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenerationTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaximaTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SelectionTypeLB;
        private System.Windows.Forms.Label CrossoverTypeLB;
        private System.Windows.Forms.Label MutationTypeLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ShowFitnessFunLB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AutomateGA;
        private System.Windows.Forms.ComboBox SelectionSchemeChooseCB;
        private System.Windows.Forms.Label label9;
    }
}