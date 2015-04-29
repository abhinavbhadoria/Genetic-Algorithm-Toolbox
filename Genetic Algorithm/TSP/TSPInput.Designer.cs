namespace Genetic_Algorithm
{
    partial class TSPInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MutationRateData = new System.Windows.Forms.Label();
            this.CrossoverRateData = new System.Windows.Forms.Label();
            this.MutationTrackBar = new System.Windows.Forms.TrackBar();
            this.CrossoverTrackBar = new System.Windows.Forms.TrackBar();
            this.MutationCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CrossoverCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectionCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CityCountTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InitialPopCountTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadTableFormButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerationCountTB = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problem Setup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(16, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 223);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.Controls.Add(this.MutationRateData);
            this.panel6.Controls.Add(this.CrossoverRateData);
            this.panel6.Controls.Add(this.MutationTrackBar);
            this.panel6.Controls.Add(this.CrossoverTrackBar);
            this.panel6.Controls.Add(this.MutationCB);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.CrossoverCB);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.SelectionCB);
            this.panel6.Controls.Add(this.label9);
            this.panel6.ForeColor = System.Drawing.Color.Brown;
            this.panel6.Location = new System.Drawing.Point(6, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 189);
            this.panel6.TabIndex = 3;
            // 
            // MutationRateData
            // 
            this.MutationRateData.AutoSize = true;
            this.MutationRateData.Location = new System.Drawing.Point(227, 144);
            this.MutationRateData.Name = "MutationRateData";
            this.MutationRateData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MutationRateData.Size = new System.Drawing.Size(21, 13);
            this.MutationRateData.TabIndex = 4;
            this.MutationRateData.Text = "0%";
            // 
            // CrossoverRateData
            // 
            this.CrossoverRateData.AutoSize = true;
            this.CrossoverRateData.Location = new System.Drawing.Point(227, 72);
            this.CrossoverRateData.Name = "CrossoverRateData";
            this.CrossoverRateData.Size = new System.Drawing.Size(21, 13);
            this.CrossoverRateData.TabIndex = 4;
            this.CrossoverRateData.Text = "0%";
            // 
            // MutationTrackBar
            // 
            this.MutationTrackBar.Location = new System.Drawing.Point(87, 140);
            this.MutationTrackBar.Maximum = 100;
            this.MutationTrackBar.Name = "MutationTrackBar";
            this.MutationTrackBar.Size = new System.Drawing.Size(134, 45);
            this.MutationTrackBar.TabIndex = 3;
            this.MutationTrackBar.Value = 5;
            this.MutationTrackBar.ValueChanged += new System.EventHandler(this.MutationTrackBar_ValueChanged);
            // 
            // CrossoverTrackBar
            // 
            this.CrossoverTrackBar.Location = new System.Drawing.Point(87, 68);
            this.CrossoverTrackBar.Maximum = 100;
            this.CrossoverTrackBar.Name = "CrossoverTrackBar";
            this.CrossoverTrackBar.Size = new System.Drawing.Size(134, 45);
            this.CrossoverTrackBar.SmallChange = 5;
            this.CrossoverTrackBar.TabIndex = 3;
            this.CrossoverTrackBar.Value = 5;
            this.CrossoverTrackBar.ValueChanged += new System.EventHandler(this.CrossoverTrackBar_ValueChanged);
            // 
            // MutationCB
            // 
            this.MutationCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MutationCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MutationCB.FormattingEnabled = true;
            this.MutationCB.Location = new System.Drawing.Point(93, 111);
            this.MutationCB.Name = "MutationCB";
            this.MutationCB.Size = new System.Drawing.Size(159, 21);
            this.MutationCB.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Mutation Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Crossover Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mutation";
            // 
            // CrossoverCB
            // 
            this.CrossoverCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CrossoverCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CrossoverCB.FormattingEnabled = true;
            this.CrossoverCB.Location = new System.Drawing.Point(93, 40);
            this.CrossoverCB.Name = "CrossoverCB";
            this.CrossoverCB.Size = new System.Drawing.Size(159, 21);
            this.CrossoverCB.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Crossover";
            // 
            // SelectionCB
            // 
            this.SelectionCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SelectionCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SelectionCB.FormattingEnabled = true;
            this.SelectionCB.Location = new System.Drawing.Point(93, 13);
            this.SelectionCB.Name = "SelectionCB";
            this.SelectionCB.Size = new System.Drawing.Size(159, 21);
            this.SelectionCB.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Selection";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Wheat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(218, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Options";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(16, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 78);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.CityCountTB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(6, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 42);
            this.panel3.TabIndex = 3;
            // 
            // CityCountTB
            // 
            this.CityCountTB.Location = new System.Drawing.Point(110, 11);
            this.CityCountTB.Name = "CityCountTB";
            this.CityCountTB.Size = new System.Drawing.Size(39, 20);
            this.CityCountTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "No of cities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Wheat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(213, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Problem";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 114);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.GenerationCountTB);
            this.panel4.Controls.Add(this.InitialPopCountTB);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label15);
            this.panel4.ForeColor = System.Drawing.Color.Brown;
            this.panel4.Location = new System.Drawing.Point(6, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 75);
            this.panel4.TabIndex = 3;
            // 
            // InitialPopCountTB
            // 
            this.InitialPopCountTB.Location = new System.Drawing.Point(111, 13);
            this.InitialPopCountTB.Name = "InitialPopCountTB";
            this.InitialPopCountTB.Size = new System.Drawing.Size(37, 20);
            this.InitialPopCountTB.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Population count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Wheat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(199, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Constraints";
            // 
            // LoadTableFormButton
            // 
            this.LoadTableFormButton.BackColor = System.Drawing.Color.Wheat;
            this.LoadTableFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTableFormButton.ForeColor = System.Drawing.Color.Brown;
            this.LoadTableFormButton.Location = new System.Drawing.Point(74, 521);
            this.LoadTableFormButton.Name = "LoadTableFormButton";
            this.LoadTableFormButton.Size = new System.Drawing.Size(148, 36);
            this.LoadTableFormButton.TabIndex = 8;
            this.LoadTableFormButton.Text = "Start";
            this.LoadTableFormButton.UseVisualStyleBackColor = false;
            this.LoadTableFormButton.Click += new System.EventHandler(this.LoadTableFormButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No of generations";
            // 
            // GenerationCountTB
            // 
            this.GenerationCountTB.Location = new System.Drawing.Point(112, 42);
            this.GenerationCountTB.Name = "GenerationCountTB";
            this.GenerationCountTB.Size = new System.Drawing.Size(37, 20);
            this.GenerationCountTB.TabIndex = 6;
            // 
            // TSPInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(307, 569);
            this.Controls.Add(this.LoadTableFormButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Name = "TSPInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSPInput";
            this.Load += new System.EventHandler(this.TSPInput_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrossoverTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label MutationRateData;
        private System.Windows.Forms.Label CrossoverRateData;
        private System.Windows.Forms.TrackBar MutationTrackBar;
        private System.Windows.Forms.TrackBar CrossoverTrackBar;
        private System.Windows.Forms.ComboBox MutationCB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CrossoverCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SelectionCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CityCountTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox InitialPopCountTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LoadTableFormButton;
        private System.Windows.Forms.TextBox GenerationCountTB;
        private System.Windows.Forms.Label label2;
    }
}