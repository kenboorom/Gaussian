namespace Gaussian
{
    partial class FormGuassianDemo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProgramName = new System.Windows.Forms.Label();
            this.gaussianChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.2226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7774F));
            this.tableLayoutPanel1.Controls.Add(this.labelProgramName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gaussianChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlot, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelProgramName
            // 
            this.labelProgramName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelProgramName, 2);
            this.labelProgramName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramName.Location = new System.Drawing.Point(2, 0);
            this.labelProgramName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgramName.Name = "labelProgramName";
            this.labelProgramName.Size = new System.Drawing.Size(658, 69);
            this.labelProgramName.TabIndex = 0;
            this.labelProgramName.Text = "Gaussian Demo: Click Plot and this program will produce a Gaussian curve by addin" +
    "g random functions with uniform PDF\'s";
            this.labelProgramName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gaussianChart
            // 
            chartArea1.Name = "ChartArea1";
            this.gaussianChart.ChartAreas.Add(chartArea1);
            this.gaussianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.gaussianChart.Legends.Add(legend1);
            this.gaussianChart.Location = new System.Drawing.Point(2, 71);
            this.gaussianChart.Margin = new System.Windows.Forms.Padding(2);
            this.gaussianChart.Name = "gaussianChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gaussianChart.Series.Add(series1);
            this.gaussianChart.Size = new System.Drawing.Size(500, 442);
            this.gaussianChart.TabIndex = 1;
            this.gaussianChart.Text = "gaussianChart";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlot.Location = new System.Drawing.Point(200, 517);
            this.buttonPlot.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(104, 31);
            this.buttonPlot.TabIndex = 2;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // FormGuassianDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGuassianDemo";
            this.Text = "GaussianDemo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProgramName;
        private System.Windows.Forms.DataVisualization.Charting.Chart gaussianChart;
        private System.Windows.Forms.Button buttonPlot;
    }
}

