using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genetic Algorithm Simulation - Evolving a Target String");

            // Target string we want to evolve
            const string target = "HELLO GENETIC ALGORITHM";
            const int populationSize = 100;
            const double mutationRate = 0.01;
            const int maxGenerations = 1000;

            var geneticAlgorithm = new GeneticAlgorithm(target, populationSize, mutationRate);
            geneticAlgorithm.Run(maxGenerations);
        }
    }

    public class GeneticAlgorithm
    {
        private readonly string _target;
        private readonly int _populationSize;
        private readonly double _mutationRate;
        private readonly Random _random = new Random();
        private List<Individual> _population;

        public GeneticAlgorithm(string target, int populationSize, double mutationRate)
        {
            _target = target;
            _populationSize = populationSize;
            _mutationRate = mutationRate;
            _population = new List<Individual>();
        }

        public void Run(int maxGenerations)
        {
            InitializePopulation();

            for (int generation = 0; generation < maxGenerations; generation++)
            {
                EvaluateFitness();
                _population = SelectParentsAndBreed();

                // Display the best result from this generation
                var bestIndividual = _population.OrderByDescending(ind => ind.Fitness).First();
                Console.WriteLine($"Generation {generation}: {bestIndividual.Genome} (Fitness: {bestIndividual.Fitness})");

                // Check if we've reached the target
                if (bestIndividual.Genome == _target)
                {
                    Console.WriteLine("Target reached!");
                    break;
                }
            }
        }

        private void InitializePopulation()
        {
            for (int i = 0; i < _populationSize; i++)
            {
                _population.Add(new Individual(_target.Length, _random));
            }
        }

        private void EvaluateFitness()
        {
            foreach (var individual in _population)
            {
                individual.CalculateFitness(_target);
            }
        }

        private List<Individual> SelectParentsAndBreed()
        {
            var newPopulation = new List<Individual>();

            // Perform elitism: retain the best individual
            var elite = _population.OrderByDescending(ind => ind.Fitness).First();
            newPopulation.Add(elite);

            // Fill the rest of the population with offspring
            while (newPopulation.Count < _populationSize)
            {
                var parent1 = SelectParent();
                var parent2 = SelectParent();
                var child = parent1.Crossover(parent2, _random);
                child.Mutate(_mutationRate, _random);
                newPopulation.Add(child);
            }

            return newPopulation;
        }

        private Individual SelectParent()
        {
            // Tournament selection
            var tournamentSize = 5;
            var tournament = _population.OrderBy(_ => _random.Next()).Take(tournamentSize);
            return tournament.OrderByDescending(ind => ind.Fitness).First();
        }
    }

    public class Individual
    {
        public string Genome { get; private set; }
        public double Fitness { get; private set; }

        public Individual(int genomeLength, Random random)
        {
            Genome = GenerateRandomGenome(genomeLength, random);
        }

        private static string GenerateRandomGenome(int length, Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            return new string(Enumerable.Range(0, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public void CalculateFitness(string target)
        {
            int score = Genome.Zip(target, (g, t) => g == t).Count(match => match);
            Fitness = (double)score / target.Length;
        }

        public Individual Crossover(Individual other, Random random)
        {
            int crossoverPoint = random.Next(Genome.Length);
            var childGenome = Genome.Substring(0, crossoverPoint) + other.Genome.Substring(crossoverPoint);
            return new Individual(childGenome);
        }

        public void Mutate(double mutationRate, Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            var genomeArray = Genome.ToCharArray();

            for (int i = 0; i < genomeArray.Length; i++)
            {
                if (random.NextDouble() < mutationRate)
                {
                    genomeArray[i] = chars[random.Next(chars.Length)];
                }
            }

            Genome = new string(genomeArray);
        }

        // Constructor for offspring
        private Individual(string genome)
        {
            Genome = genome;
        }
    }
}
