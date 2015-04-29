namespace Genetic_Algorithm
{
    partial class TSPGraphInput
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
            this.DistanceMatrixDGV = new System.Windows.Forms.DataGridView();
            this.ProccedBTN = new System.Windows.Forms.Button();
            this.RandomFillLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMatrixDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance matrix";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistanceMatrixDGV
            // 
            this.DistanceMatrixDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DistanceMatrixDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DistanceMatrixDGV.BackgroundColor = System.Drawing.Color.Tomato;
            this.DistanceMatrixDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DistanceMatrixDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DistanceMatrixDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DistanceMatrixDGV.Location = new System.Drawing.Point(49, 47);
            this.DistanceMatrixDGV.Name = "DistanceMatrixDGV";
            this.DistanceMatrixDGV.RowHeadersWidth = 50;
            this.DistanceMatrixDGV.Size = new System.Drawing.Size(450, 450);
            this.DistanceMatrixDGV.TabIndex = 3;
            // 
            // ProccedBTN
            // 
            this.ProccedBTN.BackColor = System.Drawing.Color.Wheat;
            this.ProccedBTN.ForeColor = System.Drawing.Color.Brown;
            this.ProccedBTN.Location = new System.Drawing.Point(222, 512);
            this.ProccedBTN.Name = "ProccedBTN";
            this.ProccedBTN.Size = new System.Drawing.Size(114, 40);
            this.ProccedBTN.TabIndex = 4;
            this.ProccedBTN.Text = "Procced";
            this.ProccedBTN.UseVisualStyleBackColor = false;
            this.ProccedBTN.Click += new System.EventHandler(this.ProccedBTN_Click);
            // 
            // RandomFillLB
            // 
            this.RandomFillLB.AutoSize = true;
            this.RandomFillLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomFillLB.ForeColor = System.Drawing.Color.Snow;
            this.RandomFillLB.Location = new System.Drawing.Point(471, 542);
            this.RandomFillLB.Name = "RandomFillLB";
            this.RandomFillLB.Size = new System.Drawing.Size(59, 13);
            this.RandomFillLB.TabIndex = 5;
            this.RandomFillLB.Text = "RandomFill";
            this.RandomFillLB.Click += new System.EventHandler(this.RandomFillLB_Click);
            // 
            // TSPGraphInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(542, 564);
            this.Controls.Add(this.RandomFillLB);
            this.Controls.Add(this.ProccedBTN);
            this.Controls.Add(this.DistanceMatrixDGV);
            this.Controls.Add(this.label1);
            this.Name = "TSPGraphInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSPGraphInput";
            this.Load += new System.EventHandler(this.TSPGraphInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DistanceMatrixDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DistanceMatrixDGV;
        private System.Windows.Forms.Button ProccedBTN;
        private System.Windows.Forms.Label RandomFillLB;
    }
}