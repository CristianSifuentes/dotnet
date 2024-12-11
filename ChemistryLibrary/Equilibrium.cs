using System;

namespace ChemistryLibrary
{
    public static class Equilibrium
    {
        // Calculate the equilibrium constant (K) from concentrations
        public static double CalculateEquilibriumConstant(double[] products, double[] reactants, int[] productCoefficients, int[] reactantCoefficients)
        {
            if (products.Length != productCoefficients.Length || reactants.Length != reactantCoefficients.Length)
            {
                throw new ArgumentException("Mismatched lengths for concentrations and coefficients.");
            }

            double numerator = 1.0;
            double denominator = 1.0;

            for (int i = 0; i < products.Length; i++)
            {
                numerator *= Math.Pow(products[i], productCoefficients[i]);
            }

            for (int i = 0; i < reactants.Length; i++)
            {
                denominator *= Math.Pow(reactants[i], reactantCoefficients[i]);
            }

            return numerator / denominator;
        }

        // Calculate the reaction quotient (Q) from current concentrations
        public static double CalculateReactionQuotient(double[] products, double[] reactants, int[] productCoefficients, int[] reactantCoefficients)
        {
            // Same formula as equilibrium constant but for current (non-equilibrium) concentrations
            return CalculateEquilibriumConstant(products, reactants, productCoefficients, reactantCoefficients);
        }

        // Determine if a system is at equilibrium
        public static string DetermineEquilibriumState(double Q, double K)
        {
            if (Q == K) return "The system is at equilibrium.";
            return Q > K ? "The system will shift to the reactants." : "The system will shift to the products.";
        }
    }
}
