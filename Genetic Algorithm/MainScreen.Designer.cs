namespace Genetic_Algorithm
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.FunctionMaximizeLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KightsTourLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genetic Algorithm Toolbox and Application";
            this.toolTip1.SetToolTip(this.label1, "By: Abhinav, Dhruv, Kaustubh, Anchit");
            // 
            // FunctionMaximizeLB
            // 
            this.FunctionMaximizeLB.AutoSize = true;
            this.FunctionMaximizeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionMaximizeLB.ForeColor = System.Drawing.Color.Brown;
            this.FunctionMaximizeLB.Location = new System.Drawing.Point(43, 33);
            this.FunctionMaximizeLB.Name = "FunctionMaximizeLB";
            this.FunctionMaximizeLB.Size = new System.Drawing.Size(123, 17);
            this.FunctionMaximizeLB.TabIndex = 0;
            this.FunctionMaximizeLB.Text = "Maximize Function";
            this.toolTip1.SetToolTip(this.FunctionMaximizeLB, "Performs function maximization using genetic algorithm(selection, crossover, muta" +
        "tion).");
            this.FunctionMaximizeLB.Click += new System.EventHandler(this.FunctionMaximizeLB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "1.";
            // 
            // KightsTourLB
            // 
            this.KightsTourLB.AutoSize = true;
            this.KightsTourLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KightsTourLB.ForeColor = System.Drawing.Color.Brown;
            this.KightsTourLB.Location = new System.Drawing.Point(43, 64);
            this.KightsTourLB.Name = "KightsTourLB";
            this.KightsTourLB.Size = new System.Drawing.Size(92, 17);
            this.KightsTourLB.TabIndex = 0;
            this.KightsTourLB.Text = "Knight\'s Tour";
            this.toolTip1.SetToolTip(this.KightsTourLB, "Knight\'s tour problem is an instance of the more general Hamiltonian path problem" +
        " in graph theory.");
            this.KightsTourLB.Click += new System.EventHandler(this.KightsTourLB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "2.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.KightsTourLB);
            this.panel1.Controls.Add(this.FunctionMaximizeLB);
            this.panel1.Location = new System.Drawing.Point(75, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 116);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Submitted to Dr. Pankaj Agarwal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 34);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(81, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "By Abhinav, Dhruv, Kaustubh, Anchit";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(333, 315);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FunctionMaximizeLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KightsTourLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}