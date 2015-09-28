using System;
using System.Windows.Forms;

namespace KalmanSimPlot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            GenerateGraph();
        }

        private void GenerateGraph()
        {
            // reset textbox colors in case of prior input errors
            textBoxInitialEstimate.BackColor = System.Drawing.Color.White;
            textBoxInitialEstimateError.BackColor = System.Drawing.Color.White;
            textBoxMeasurementNoise.BackColor = System.Drawing.Color.White;
            textBoxProcessNoise.BackColor = System.Drawing.Color.White;
            textBoxIntervals.BackColor = System.Drawing.Color.White;

            double initialEstimate;
            if (!double.TryParse(textBoxInitialEstimate.Text, out initialEstimate))
            {
                initialEstimate = 0.0;
                textBoxInitialEstimate.BackColor = System.Drawing.Color.Red;
            }

            double initialEstimateError;
            if (!double.TryParse(textBoxInitialEstimateError.Text, out initialEstimateError) || initialEstimateError < 0)
            {
                initialEstimateError = 1.0;
                textBoxInitialEstimateError.BackColor = System.Drawing.Color.Red;
            }

            double measurementNoise;
            if (!double.TryParse(textBoxMeasurementNoise.Text, out measurementNoise) || measurementNoise < 0)
            {
                measurementNoise = 0.025;
                textBoxMeasurementNoise.BackColor = System.Drawing.Color.Red;
            }

            double processNoise;
            if (!double.TryParse(textBoxProcessNoise.Text, out processNoise) || processNoise < 0)
            {
                processNoise = 0.01;
                textBoxProcessNoise.BackColor = System.Drawing.Color.Red;
            }
            
            int numIntervals;
            if (!int.TryParse(textBoxIntervals.Text, out numIntervals) || numIntervals < 1)
            {
                numIntervals = 100;
                textBoxIntervals.BackColor = System.Drawing.Color.Red;
            }
            
            KalmanValues results = KalmanSimulator.ApplyKalmanFilter(initialEstimate, initialEstimateError, measurementNoise, processNoise, numIntervals);

            chartMain.Series["Actual"].Points.DataBindY(results.ActualSignal);

            chartMain.Series["Measured"].Points.DataBindY(results.MeasuredValues);

            chartMain.Series["Filtered"].Points.DataBindY(results.FilteredValues);
        }
        
        private void textBoxKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GenerateGraph();
            }
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            GenerateGraph();
        }
    }
}
