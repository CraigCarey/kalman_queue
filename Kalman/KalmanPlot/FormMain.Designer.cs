namespace KalmanSimPlot
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox04 = new System.Windows.Forms.GroupBox();
            this.textBoxProcessNoise = new System.Windows.Forms.TextBox();
            this.groupBox03 = new System.Windows.Forms.GroupBox();
            this.textBoxMeasurementNoise = new System.Windows.Forms.TextBox();
            this.groupBox05 = new System.Windows.Forms.GroupBox();
            this.textBoxIntervals = new System.Windows.Forms.TextBox();
            this.groupBox01 = new System.Windows.Forms.GroupBox();
            this.textBoxInitialEstimate = new System.Windows.Forms.TextBox();
            this.textBoxInitialEstimateError = new System.Windows.Forms.TextBox();
            this.groupBox02 = new System.Windows.Forms.GroupBox();
            this.buttonGenerateGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBox04.SuspendLayout();
            this.groupBox03.SuspendLayout();
            this.groupBox05.SuspendLayout();
            this.groupBox01.SuspendLayout();
            this.groupBox02.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMain.BackColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "k";
            chartArea1.AxisY.Title = "Amplitude";
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Silver;
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(-4, 1);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Measured";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Filtered";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Actual";
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Series.Add(series3);
            this.chartMain.Size = new System.Drawing.Size(729, 487);
            this.chartMain.TabIndex = 6;
            this.chartMain.Text = "chart1";
            // 
            // groupBox04
            // 
            this.groupBox04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox04.Controls.Add(this.textBoxProcessNoise);
            this.groupBox04.Location = new System.Drawing.Point(603, 266);
            this.groupBox04.Name = "groupBox04";
            this.groupBox04.Size = new System.Drawing.Size(120, 51);
            this.groupBox04.TabIndex = 3;
            this.groupBox04.TabStop = false;
            this.groupBox04.Text = "Process Noise";
            // 
            // textBoxProcessNoise
            // 
            this.textBoxProcessNoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcessNoise.Location = new System.Drawing.Point(6, 20);
            this.textBoxProcessNoise.Name = "textBoxProcessNoise";
            this.textBoxProcessNoise.Size = new System.Drawing.Size(108, 20);
            this.textBoxProcessNoise.TabIndex = 0;
            this.textBoxProcessNoise.Text = "0.01";
            this.textBoxProcessNoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProcessNoise.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyUp);
            // 
            // groupBox03
            // 
            this.groupBox03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox03.Controls.Add(this.textBoxMeasurementNoise);
            this.groupBox03.Location = new System.Drawing.Point(603, 209);
            this.groupBox03.Name = "groupBox03";
            this.groupBox03.Size = new System.Drawing.Size(120, 51);
            this.groupBox03.TabIndex = 2;
            this.groupBox03.TabStop = false;
            this.groupBox03.Text = "Measurement Noise";
            // 
            // textBoxMeasurementNoise
            // 
            this.textBoxMeasurementNoise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMeasurementNoise.Location = new System.Drawing.Point(7, 20);
            this.textBoxMeasurementNoise.Name = "textBoxMeasurementNoise";
            this.textBoxMeasurementNoise.Size = new System.Drawing.Size(107, 20);
            this.textBoxMeasurementNoise.TabIndex = 0;
            this.textBoxMeasurementNoise.Text = "0.025";
            this.textBoxMeasurementNoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMeasurementNoise.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyUp);
            // 
            // groupBox05
            // 
            this.groupBox05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox05.Controls.Add(this.textBoxIntervals);
            this.groupBox05.Location = new System.Drawing.Point(603, 319);
            this.groupBox05.Name = "groupBox05";
            this.groupBox05.Size = new System.Drawing.Size(120, 51);
            this.groupBox05.TabIndex = 4;
            this.groupBox05.TabStop = false;
            this.groupBox05.Text = "Intervals";
            // 
            // textBoxIntervals
            // 
            this.textBoxIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntervals.Location = new System.Drawing.Point(6, 20);
            this.textBoxIntervals.Name = "textBoxIntervals";
            this.textBoxIntervals.Size = new System.Drawing.Size(108, 20);
            this.textBoxIntervals.TabIndex = 0;
            this.textBoxIntervals.Text = "100";
            this.textBoxIntervals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIntervals.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyUp);
            // 
            // groupBox01
            // 
            this.groupBox01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox01.Controls.Add(this.textBoxInitialEstimate);
            this.groupBox01.Location = new System.Drawing.Point(603, 95);
            this.groupBox01.Name = "groupBox01";
            this.groupBox01.Size = new System.Drawing.Size(120, 51);
            this.groupBox01.TabIndex = 0;
            this.groupBox01.TabStop = false;
            this.groupBox01.Text = "Initial Estimate";
            // 
            // textBoxInitialEstimate
            // 
            this.textBoxInitialEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInitialEstimate.Location = new System.Drawing.Point(6, 20);
            this.textBoxInitialEstimate.Name = "textBoxInitialEstimate";
            this.textBoxInitialEstimate.Size = new System.Drawing.Size(108, 20);
            this.textBoxInitialEstimate.TabIndex = 0;
            this.textBoxInitialEstimate.Text = "0.0";
            this.textBoxInitialEstimate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInitialEstimate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyUp);
            // 
            // textBoxInitialEstimateError
            // 
            this.textBoxInitialEstimateError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInitialEstimateError.Location = new System.Drawing.Point(6, 20);
            this.textBoxInitialEstimateError.Name = "textBoxInitialEstimateError";
            this.textBoxInitialEstimateError.Size = new System.Drawing.Size(108, 20);
            this.textBoxInitialEstimateError.TabIndex = 0;
            this.textBoxInitialEstimateError.Text = "1.0";
            this.textBoxInitialEstimateError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInitialEstimateError.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyUp);
            // 
            // groupBox02
            // 
            this.groupBox02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox02.Controls.Add(this.textBoxInitialEstimateError);
            this.groupBox02.Location = new System.Drawing.Point(603, 152);
            this.groupBox02.Name = "groupBox02";
            this.groupBox02.Size = new System.Drawing.Size(120, 51);
            this.groupBox02.TabIndex = 1;
            this.groupBox02.TabStop = false;
            this.groupBox02.Text = "Initial Estimate Error";
            // 
            // buttonGenerateGraph
            // 
            this.buttonGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateGraph.Location = new System.Drawing.Point(610, 389);
            this.buttonGenerateGraph.Name = "buttonGenerateGraph";
            this.buttonGenerateGraph.Size = new System.Drawing.Size(107, 38);
            this.buttonGenerateGraph.TabIndex = 5;
            this.buttonGenerateGraph.Text = "Regenerate";
            this.buttonGenerateGraph.UseVisualStyleBackColor = true;
            this.buttonGenerateGraph.Click += new System.EventHandler(this.buttonGenerateGraph_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(735, 487);
            this.Controls.Add(this.buttonGenerateGraph);
            this.Controls.Add(this.groupBox02);
            this.Controls.Add(this.groupBox01);
            this.Controls.Add(this.groupBox05);
            this.Controls.Add(this.groupBox03);
            this.Controls.Add(this.groupBox04);
            this.Controls.Add(this.chartMain);
            this.Name = "FormMain";
            this.Text = "Simplified Kalman Filter";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBox04.ResumeLayout(false);
            this.groupBox04.PerformLayout();
            this.groupBox03.ResumeLayout(false);
            this.groupBox03.PerformLayout();
            this.groupBox05.ResumeLayout(false);
            this.groupBox05.PerformLayout();
            this.groupBox01.ResumeLayout(false);
            this.groupBox01.PerformLayout();
            this.groupBox02.ResumeLayout(false);
            this.groupBox02.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.GroupBox groupBox01;
        private System.Windows.Forms.TextBox textBoxInitialEstimateError;
        private System.Windows.Forms.GroupBox groupBox02;
        private System.Windows.Forms.TextBox textBoxProcessNoise;
        private System.Windows.Forms.GroupBox groupBox03;
        private System.Windows.Forms.TextBox textBoxInitialEstimate;
        private System.Windows.Forms.GroupBox groupBox04;        
        private System.Windows.Forms.TextBox textBoxMeasurementNoise;
        private System.Windows.Forms.GroupBox groupBox05;
        private System.Windows.Forms.TextBox textBoxIntervals;
        private System.Windows.Forms.Button buttonGenerateGraph;
                
    }
}

