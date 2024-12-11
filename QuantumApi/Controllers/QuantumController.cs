using Microsoft.AspNetCore.Mvc;
using System;

namespace QuantumApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuantumController : ControllerBase
    {
        // Simulate Superposition
        [HttpGet("superposition")]
        public IActionResult GetSuperposition()
        {
            // Generate probabilities for quantum state
            var random = new Random();
            double amplitude0 = random.NextDouble();
            double amplitude1 = Math.Sqrt(1 - amplitude0 * amplitude0);

            return Ok(new
            {
                State0 = Math.Round(amplitude0, 4),
                State1 = Math.Round(amplitude1, 4),
                Probability0 = Math.Round(amplitude0 * amplitude0, 4),
                Probability1 = Math.Round(amplitude1 * amplitude1, 4)
            });
        }

        // Simulate Measurement of a Quantum State
        [HttpPost("measure")]
        public IActionResult Measure([FromBody] QuantumState state)
        {
            var random = new Random();
            double result = random.NextDouble();
            string measuredState = result <= state.Probability0 ? "0" : "1";

            return Ok(new
            {
                MeasuredState = measuredState,
                InputState = state
            });
        }
    }

    // DTO for Quantum State
    public class QuantumState
    {
        public double Probability0 { get; set; }
        public double Probability1 { get; set; }
    }
}
