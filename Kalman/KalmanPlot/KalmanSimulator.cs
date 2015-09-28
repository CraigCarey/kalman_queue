using System;

namespace KalmanSimPlot
{
    public struct KalmanValues
    {
        public double[] ActualSignal;
        public double[] MeasuredValues;
        public double[] FilteredValues;
    }

    // Basic signal simulator for testing Simplified Kalman Filter
    // Generates a random walk signal, adds noise to simulate
    // measured signal, then feeds the measured signal into the
    // filter. Results are plotted on a line chart    
    public static class KalmanSimulator
    {
        private static Random rand = new Random();
        
        public static KalmanValues ApplyKalmanFilter(double initialEstimate, double initialEstimateError, double measurementNoise, double processNoise, int numIntervals)
        {
            KalmanValues kalmanValues = new KalmanValues();

            // Generate "actual" signal data
            kalmanValues.ActualSignal = RandomWalkSignal(numIntervals, processNoise);

            // Simulate inaccurate measurements by adding noise to signal
            kalmanValues.MeasuredValues = MeasuredSignalWithNoise(kalmanValues.ActualSignal, measurementNoise);

            // Apply the filter to the measured data
            kalmanValues.FilteredValues = FilterMeasurements(kalmanValues.MeasuredValues, initialEstimate, measurementNoise, initialEstimateError, processNoise);

            return kalmanValues;
        }

        // the Kalman filtered signal
        public static double[] FilterMeasurements(double[] measuredValues, double initialEstimate, double measurementNoise, double initialEstimateError, double processNoise)
        {
            SimplifiedKalmanFilter kalmanFilter = new SimplifiedKalmanFilter(initialEstimate, initialEstimateError, measurementNoise, processNoise);

            double[] filterEstimates = new double[measuredValues.Length];

            for (int i = 0; i < measuredValues.Length; i++)
            {
                filterEstimates[i] = kalmanFilter.TimeUpdate(measuredValues[i]);
            }

            return filterEstimates;
        }

        // the 'actual' signal
        public static double[] RandomWalkSignal(int numEntries, double processNoise)
        {
            double[] randomWalk = new double[numEntries];

            randomWalk[0] = 0;

            for (int i = 1; i < randomWalk.Length; i++)
            {
                // generate the next value by stepping away from the previous value by a small amount
                randomWalk[i] = randomWalk[i - 1] + (rand.NextDouble() * 2 * processNoise) - processNoise;
            }

            return randomWalk;
        }

        // noise added to actual signal to simulate inaccurate measurements
        public static double[] MeasuredSignalWithNoise(double[] signal, double measurementNoise)
        {
            double[] measured = new double[signal.Length];

            for (int i = 0; i < signal.Length; ++i)
            {
                measured[i] = signal[i] + (rand.NextDouble() * 2 * measurementNoise) - measurementNoise;
            }

            return measured;
        }
    }
}