using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlackbodySpectrum.Pages
{
    public class BlackbodyModel : PageModel
    {
        public double[] Wavelengths { get; set; } = new double[100];
        public double[] Intensities { get; set; } = new double[100];

        public void OnGet(double temperature = 5000)
        {
            // Constants
            double h = 6.626e-34; // Planck constant (J·s)
            double c = 3e8; // Speed of light (m/s)
            double k = 1.381e-23; // Boltzmann constant (J/K)

            // Calculate spectrum
            for (int i = 0; i < Wavelengths.Length; i++)
            {
                double wavelength = 1e-7 + i * 1e-7; // Wavelengths in meters
                Wavelengths[i] = wavelength * 1e9; // Convert to nanometers

                // Planck's radiation formula
                double intensity = (2 * h * Math.Pow(c, 2) / Math.Pow(wavelength, 5))
                    * (1 / (Math.Exp(h * c / (wavelength * k * temperature)) - 1));

                Intensities[i] = intensity;
            }
        }
    }
}
