using Microsoft.VisualStudio.TestTools.UnitTesting;
using FourierLibrary;
using System;
using System.Numerics;

namespace FourierLibrary.Tests
{
    [TestClass]
    public class FourierTransformTests
    {
        [TestMethod]
        public void ComputeDFT_ShouldReturnExpectedFrequencies()
        {
            // Arrange
            double[] signal = { 1.0, 0.0, -1.0, 0.0 }; // A simple sinusoidal signal
            Complex[] expected = {
                new Complex(0, 0),
                new Complex(0, -2),
                new Complex(0, 0),
                new Complex(0, 2)
            };

            // Act
            var result = FourierTransform.ComputeDFT(signal);

            // Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Real, result[i].Real, 1e-10);
                Assert.AreEqual(expected[i].Imaginary, result[i].Imaginary, 1e-10);
            }
        }

        [TestMethod]
        public void ComputeIDFT_ShouldReturnOriginalSignal()
        {
            // Arrange
            Complex[] frequencies = {
                new Complex(0, 0),
                new Complex(0, -2),
                new Complex(0, 0),
                new Complex(0, 2)
            };

            double[] expectedSignal = { 1.0, 0.0, -1.0, 0.0 };

            // Act
            var result = FourierTransform.ComputeIDFT(frequencies);

            // Assert
            for (int i = 0; i < expectedSignal.Length; i++)
            {
                Assert.AreEqual(expectedSignal[i], result[i], 1e-10);
            }
        }

        [TestMethod]
        public void DFTAndIDFT_ShouldBeReversible()
        {
            // Arrange
            double[] originalSignal = { 1.0, 2.0, 3.0, 4.0 };

            // Act
            var frequencies = FourierTransform.ComputeDFT(originalSignal);
            var reconstructedSignal = FourierTransform.ComputeIDFT(frequencies);

            // Assert
            for (int i = 0; i < originalSignal.Length; i++)
            {
                Assert.AreEqual(originalSignal[i], reconstructedSignal[i], 1e-10);
            }
        }
    }
}
