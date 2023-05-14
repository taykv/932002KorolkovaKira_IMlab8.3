namespace lab8randomevents
{
    partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Prob5 = new System.Windows.Forms.Label();
			this.tbpr1 = new System.Windows.Forms.NumericUpDown();
			this.tbpr2 = new System.Windows.Forms.NumericUpDown();
			this.tbpr3 = new System.Windows.Forms.NumericUpDown();
			this.tbpr4 = new System.Windows.Forms.NumericUpDown();
			this.tbN = new System.Windows.Forms.NumericUpDown();
			this.tbpr7 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(249, 32);
			this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(788, 399);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 65);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Prob 1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 100);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Prob 2";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 132);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Prob 3";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(37, 168);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 17);
			this.label9.TabIndex = 7;
			this.label9.Text = "Prob 4";
			// 
			// Prob5
			// 
			this.Prob5.AutoSize = true;
			this.Prob5.Location = new System.Drawing.Point(37, 200);
			this.Prob5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Prob5.Name = "Prob5";
			this.Prob5.Size = new System.Drawing.Size(50, 17);
			this.Prob5.TabIndex = 10;
			this.Prob5.Text = "Prob 5";
			// 
			// tbpr1
			// 
			this.tbpr1.DecimalPlaces = 2;
			this.tbpr1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.tbpr1.Location = new System.Drawing.Point(110, 63);
			this.tbpr1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbpr1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbpr1.Name = "tbpr1";
			this.tbpr1.Size = new System.Drawing.Size(59, 23);
			this.tbpr1.TabIndex = 11;
			this.tbpr1.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
			// 
			// tbpr2
			// 
			this.tbpr2.DecimalPlaces = 2;
			this.tbpr2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.tbpr2.Location = new System.Drawing.Point(110, 97);
			this.tbpr2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbpr2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbpr2.Name = "tbpr2";
			this.tbpr2.Size = new System.Drawing.Size(59, 23);
			this.tbpr2.TabIndex = 12;
			this.tbpr2.Value = new decimal(new int[] {
            22,
            0,
            0,
            131072});
			// 
			// tbpr3
			// 
			this.tbpr3.DecimalPlaces = 2;
			this.tbpr3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.tbpr3.Location = new System.Drawing.Point(110, 129);
			this.tbpr3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbpr3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbpr3.Name = "tbpr3";
			this.tbpr3.Size = new System.Drawing.Size(59, 23);
			this.tbpr3.TabIndex = 13;
			this.tbpr3.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
			// 
			// tbpr4
			// 
			this.tbpr4.DecimalPlaces = 2;
			this.tbpr4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.tbpr4.Location = new System.Drawing.Point(110, 165);
			this.tbpr4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbpr4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbpr4.Name = "tbpr4";
			this.tbpr4.Size = new System.Drawing.Size(59, 23);
			this.tbpr4.TabIndex = 14;
			this.tbpr4.Value = new decimal(new int[] {
            4,
            0,
            0,
            131072});
			// 
			// tbN
			// 
			this.tbN.Location = new System.Drawing.Point(137, 269);
			this.tbN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.tbN.Name = "tbN";
			this.tbN.Size = new System.Drawing.Size(84, 23);
			this.tbN.TabIndex = 17;
			this.tbN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// tbpr7
			// 
			this.tbpr7.Location = new System.Drawing.Point(110, 196);
			this.tbpr7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbpr7.Name = "tbpr7";
			this.tbpr7.ReadOnly = true;
			this.tbpr7.Size = new System.Drawing.Size(57, 23);
			this.tbpr7.TabIndex = 18;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 271);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 17);
			this.label10.TabIndex = 33;
			this.label10.Text = "Number of trials";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(40, 352);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 36);
			this.button1.TabIndex = 34;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 483);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tbpr7);
			this.Controls.Add(this.tbN);
			this.Controls.Add(this.tbpr4);
			this.Controls.Add(this.tbpr3);
			this.Controls.Add(this.tbpr2);
			this.Controls.Add(this.tbpr1);
			this.Controls.Add(this.Prob5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chart1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbpr4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Prob5;
        private System.Windows.Forms.NumericUpDown tbpr1;
        private System.Windows.Forms.NumericUpDown tbpr2;
        private System.Windows.Forms.NumericUpDown tbpr3;
        private System.Windows.Forms.NumericUpDown tbpr4;
        private System.Windows.Forms.NumericUpDown tbN;
        private System.Windows.Forms.TextBox tbpr7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

