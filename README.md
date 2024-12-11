# dotnet
The .NET CLI (dotnet) is a command-line tool that is a part of the .NET SDK. Provides an interface to create, compile, publish, run, and manage .NET applications and projects. It is an essential tool for developers working on .NET projects, specially for cross-platform environments and automation in CI/CD.


<!-- Template	Command	Description
classlib	dotnet new classlib	Creates a class library.
web	dotnet new web	Creates a blank ASP.NET Core web application.
webapi	dotnet new webapi	Creates an ASP.NET Core Web API application.
mvc	dotnet new mvc	Creates an ASP.NET Core MVC application.
blazorserver	dotnet new blazorserver	Creates a Blazor Server application.
blazorwasm	dotnet new blazorwasm	Creates a Blazor WebAssembly application.
xunit	dotnet new xunit	Creates a project for unit testing using xUnit.
mstest	dotnet new mstest	Creates a project for unit testing using MSTest.
worker	dotnet new worker	Creates a background worker service. -->


## Using dotnet new to Create Projects

| **Template** | **Command** | **Description** |
| --- | --- | --- |
| **console** | dotnet new console | Create a console application.  |
| **classlib** | dotnet new classlib |  Create a class library. |
| **web** | dotnet new web | Creates an empty ASP.NET Core web application. |
| **webapi** | dotnet new webapi |   Create a web API with ASP.NET Core. |
| **mvc** | dotnet new mvc |   Create an ASP.NET Core application using the MVC pattern. |
| **blazorserver** |  dotnet new blazorserver |  Create a Blazor Server application. |
| **blazorwasm** | dotnet new blazorwasm |   Create a Blazor WebAssembly application.|
| **xunit** | dotnet new xunit |   Create a unit testing project with xUnit. |
| **mstest** | dotnet new mstest |   Create a unit testing project with MSTest. |
| **worker** | dotnet new worker |   Creates a background worker service. |


## Console application (console) Genetic Algorithms.
This application will simulate evolution using natural selection and genetic crossover to solve an optimization problem.

dotnet new classlib	

```bash
dotnet new console -n GeneticAlgorithmSimulation
```

```bash
cd GeneticAlgorithmSimulation
```

```bash
dotnet run
```

## class library (classlib) Matrix Operations

The project will implement mathematical concepts, such as Matrix Operations, leveraging programming best practice.

dotnet new classlib -n MathLibrary

Step 1: Create a Solution
bash
```bash
dotnet new sln -n DotNetSolution
```
Step 2: Create the Class Library

```bash
dotnet new classlib -n MathLibrary
```
Step 3: Add the Class Library to the Solution
```bash
dotnet sln DotNetSolution.sln add MathLibrary/MathLibrary.csproj

```
Step 5: Create a Console App for Testing

```bash
dotnet new console -n MathLibraryDemo
dotnet sln DotNetSolution.sln add MathLibraryDemo/MathLibraryDemo.csproj
```

Step 6: Add Reference from Console App to Class Library
```bash
dotnet add MathLibraryDemo reference MathLibrary/MathLibrary.csproj

```
## web API (webapi) quantum physics.

dotnet new webapi -n QuantumApi

 The API will simulate quantum states and operations like superposition and measurement. 


```bash
dotnet new webapi -n QuantumApi
dotnet sln DotNetSolution.sln add QuantumApi/QuantumApi.csproj
dotnet add QuantumApi package MathNet.Numerics
dotnet run --project QuantumApi
```

Step 1: Create s Solution
Step 2: Create the Web API Project
Step 3: Add the Web API Project to the Solution
Step 4: Install Required NuGet Package
Step 5: Implement the Web API
Step 6: Test the API
Step 7: Example Requests
Step 8: Optional Frontend Integration

## MVC (mvc) quantum physics concepts.

The project will simulate quantum states and provide interactive web interface for users to explore superposition and measurement operations.

```bash
dotnet new mvc -n QuantumMvc
dotnet new mvc -n LacanMvc
```


# xUnit (xunit) equilibrium constant
This project will implement and test functions for calculating the equilibrium constant (K) and reaction quotient (Q) in chemistry.

```bash
dotnet new classlib -n ChemistryLibrary
dotnet sln ChemistryXunitSolution.sln add ChemistryLibrary/ChemistryLibrary.csproj
dotnet new xunit -n ChemistryLibrary.Tests
dotnet sln ChemistryXunitSolution.sln add ChemistryLibrary.Tests/ChemistryLibrary.Tests.csproj
dotnet add ChemistryLibrary.Tests reference ChemistryLibrary/ChemistryLibrary.csproj
```

# MSTest to test Fourier Transform

Example of creating a unit testing project using MSTest to test implementations of Fourier Transform, a core concept in advanced mathematics used in signal processing and data analysis.

```bash
dotnet new classlib -n FourierLibrary
dotnet sln DotNetSolution.sln add FourierLibrary/FourierLibrary.csproj
dotnet new mstest -n FourierLibrary.Tests
dotnet sln DotNetSolution.sln add FourierLibrary.Tests/FourierLibrary.Tests.csproj
dotnet add FourierLibrary.Tests reference FourierLibrary/FourierLibrary.csproj
dotnet restore
dotnet test
```

# Worker Simulating Particle Decay

A background worker simulation radioactive decay of particles ov er time using probabilistic methods.

```bash
dotnet new worker -n ParticleDecayWorker
```

# Razor Pages Planck radiation law 

```bash
dotnet new razor -n BlackbodySpectrum
```

# Blazor Server time dilation

```bash
dotnet new blazorserver -n TimeDilationApp
```
