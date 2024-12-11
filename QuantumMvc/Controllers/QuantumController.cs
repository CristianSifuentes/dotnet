using Microsoft.AspNetCore.Mvc;
using QuantumMvc.Models;
using System;

namespace QuantumMvc.Controllers
{
    public class QuantumController : Controller
    {
        // Displays the quantum superposition page
        public IActionResult Index()
        {
            var random = new Random();

            // Generate random amplitudes for superposition
            double amplitude0 = random.NextDouble();
            double amplitude1 = Math.Sqrt(1 - amplitude0 * amplitude0);

            var model = new QuantumState
            {
                State0Amplitude = Math.Round(amplitude0, 4),
                State1Amplitude = Math.Round(amplitude1, 4),
                Probability0 = Math.Round(amplitude0 * amplitude0, 4),
                Probability1 = Math.Round(amplitude1 * amplitude1, 4)
            };

            return View(model);
        }

        // Simulates the measurement of a quantum state
        [HttpPost]
        public IActionResult Measure(QuantumState model)
        {
            var random = new Random();
            double result = random.NextDouble();

            model.MeasuredState = result <= model.Probability0 ? "|0⟩" : "|1⟩";

            return View("Index", model);
        }
    }
}
