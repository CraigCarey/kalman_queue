namespace KalmanSimPlot
{
    // A simplified version of the Kalman Filter
    // Works on scalar values only, and doesn't
    // take into account the state transition model
    // or the control-input model
    public class SimplifiedKalmanFilter
    {
        private double q;   // covariance of the process noise  
        private double r;   // covariance of the observation noise
        private double p;   // predicted estimate covariance        
        private double k;   // Kalman gain
        private double x;   // estimate of true state

        public SimplifiedKalmanFilter(double initialEstimate, double initialEstimateError, double measurementNoise, double processNoise)
        {
            x = initialEstimate;
            r = measurementNoise;
            p = initialEstimateError;
            q = processNoise;
        }

        public double TimeUpdate(double measurement)
        {
            x = measurementUpdate(measurement);
            return x;
        }

        private double measurementUpdate(double measurement)
        {
            k = (p + q) / (p + q + r);
            p = p * (1 - k);
            return x + (measurement - x) * k;
        }
    }
}
