using KalmanSimPlot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KalmanTest
{
    [TestClass]
    public class SimplifiedKalmanFilterTest
    {
        [TestMethod]
        public void TestKalmanFilter01()
        {
            // values from bilgin.esme.org/BitsBytes/KalmanFilterforDummies
            double[] testSignal = { 0.39, 0.50, 0.48, 0.29, 0.25, 0.32, 0.34, 0.48, 0.41, 0.45 };
            double[] actualResults = { 0.355, 0.424, 0.442, 0.405, 0.375, 0.365, 0.362, 0.377, 0.380, 0.387 };

            const double InitialEstimate = 0;
            const double InitialEstimateError = 1;
            const double MeasurementError = 0.1;
            const double ProcessNoise = 0.000001;

            SimplifiedKalmanFilter kf = new SimplifiedKalmanFilter(InitialEstimate, InitialEstimateError, MeasurementError, ProcessNoise);

            double[] testResults = new double[testSignal.Length];
            
            for (int i = 0; i < testSignal.Length; i++)
            {
                testResults[i] = Math.Round(kf.TimeUpdate(testSignal[i]), 3);
                Assert.AreEqual(actualResults[i], testResults[i], 0.01);
            }
        }
    }
}
