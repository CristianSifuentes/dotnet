using System;
using System.Numerics;

namespace FourierLibrary
{
    public static class FourierTransform
    {
        // Computes the Discrete Fourier Transform (DFT)
        public static Complex[] ComputeDFT(double[] input)
        {
            int n = input.Length;
            Complex[] output = new Complex[n];

            for (int k = 0; k < n; k++) // For each output element
            {
                Complex sum = Complex.Zero;
                for (int t = 0; t < n; t++) // For each input element
                {
                    double angle = -2.0 * Math.PI * t * k / n;
                    sum += new Complex(input[t] * Math.Cos(angle), input[t] * Math.Sin(angle));
                }
                output[k] = sum;
            }

            return output;
        }

        // Computes the Inverse Discrete Fourier Transform (IDFT)
        public static double[] ComputeIDFT(Complex[] input)
        {
            int n = input.Length;
            double[] output = new double[n];

            for (int t = 0; t < n; t++) // For each output element
            {
                Complex sum = Complex.Zero;
                for (int k = 0; k < n; k++) // For each input element
                {
                    double angle = 2.0 * Math.PI * t * k / n;
                    sum += new Complex(input[k].Real * Math.Cos(angle) - input[k].Imaginary * Math.Sin(angle),
                                       input[k].Real * Math.Sin(angle) + input[k].Imaginary * Math.Cos(angle));
                }
                output[t] = sum.Real / n;
            }

            return output;
        }
    }
}
