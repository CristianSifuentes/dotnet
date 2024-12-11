using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace ParticleDecayWorker
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Particle Decay Simulation Started");

            double initialParticles = 1000; // Initial number of particles
            double decayConstant = 0.1; // Decay constant (lambda)
            double timeStep = 1; // Time interval for decay

            double remainingParticles = initialParticles;

            while (!stoppingToken.IsCancellationRequested && remainingParticles > 0)
            {
                // Calculate the number of particles decayed in this time step
                double decayedParticles = remainingParticles * (1 - Math.Exp(-decayConstant * timeStep));
                remainingParticles -= decayedParticles;

                Console.WriteLine($"Time: {timeStep}s, Decayed: {decayedParticles:F2}, Remaining: {remainingParticles:F2}");
                timeStep++;

                await Task.Delay(1000, stoppingToken); // Simulate real-time decay
            }

            Console.WriteLine("All particles have decayed or the simulation was stopped.");
        }
    }
}
