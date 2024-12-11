using System;
using Xunit;
using ChemistryLibrary;

namespace ChemistryLibrary.Tests
{
    public class EquilibriumTests
    {
        [Fact]
        public void CalculateEquilibriumConstant_ShouldReturnCorrectValue()
        {
            // Arrange
            double[] products = { 2.0, 1.5 }; // Concentrations of products
            double[] reactants = { 1.0, 3.0 }; // Concentrations of reactants
            int[] productCoefficients = { 2, 1 }; // Coefficients of products
            int[] reactantCoefficients = { 1, 1 }; // Coefficients of reactants

            // Act
            double result = Equilibrium.CalculateEquilibriumConstant(products, reactants, productCoefficients, reactantCoefficients);

            // Assert
            Assert.Equal(2.25, result, precision: 2);
        }

        [Fact]
        public void CalculateReactionQuotient_ShouldMatchEquilibriumConstantForSameConcentrations()
        {
            // Arrange
            double[] products = { 1.0, 2.0 };
            double[] reactants = { 1.0, 1.0 };
            int[] productCoefficients = { 1, 2 };
            int[] reactantCoefficients = { 1, 1 };

            // Act
            double Q = Equilibrium.CalculateReactionQuotient(products, reactants, productCoefficients, reactantCoefficients);
            double K = Equilibrium.CalculateEquilibriumConstant(products, reactants, productCoefficients, reactantCoefficients);

            // Assert
            Assert.Equal(K, Q, precision: 2);
        }

        [Theory]
        [InlineData(1.0, 1.0, "The system is at equilibrium.")]
        [InlineData(1.5, 1.0, "The system will shift to the reactants.")]
        [InlineData(0.5, 1.0, "The system will shift to the products.")]
        public void DetermineEquilibriumState_ShouldReturnCorrectMessage(double Q, double K, string expected)
        {
            // Act
            string result = Equilibrium.DetermineEquilibriumState(Q, K);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
