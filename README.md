# **.NET CLI (dotnet) - Comprehensive Guide**

## **Table of Contents**
1. [Introduction to .NET CLI](#introduction-to-net-cli)
2. [Traditional .NET Development](#traditional-net-development)
3. [The Evolution .NET CLI](#the-evolution-net-cli)
4. [Main Features of .NET CLI](#main-features-of-net-cli)
5. [Main `dotnet` Commands](#main-dotnet-commands)
   - [1. Project and Solution Initialization](#1-project-and-solution-initialization)
   - [2. Compilation and Execution](#2-compilation-and-execution)
   - [3. Restoration of Dependencies](#3-restoration-of-dependencies)
   - [4. Package Management](#4-package-management)
   - [5. SDK and Runtime Information](#5-sdk-and-runtime-information)
6. [Basic Workflow with `dotnet`](#basic-workflow-with-dotnet)
7. [Integration in CI/CD](#integration-in-cicd)
8. [Common `dotnet new` Templates](#common-dotnet-new-templates)
   - [Console application `console` Genetic Algorithms](#console-application-console-genetic-algorithms)
   - [Class library `classlib` Matrix Operations](#class-library-classlib-matrix-operations)
   - [Web API `webapi` Quantum Physics](#web-api-webapi-quantum-physics)
   - [MVC `mvc` Quantum Physics Concepts](#mvc-mvc-quantum-physics-concepts)
   - [xUnit `xunit` Equilibrium Constant](#xunit-xunit-equilibrium-constant)
   - [MSTest to test Fourier Transform](#mstest-to-test-fourier-transform)
   - [Worker Simulating Particle Decay](#worker-simulating-particle-decay)
   - [Razor Pages Planck radiation law](#razor-pages-planck-radiation-law)
   - [Blazor Server time dilation](#blazor-server-time-dilation)
9. [Advantages of the .NET CLI](#advantages-of-the-net-cli)
10. [Advanced `dotnet` Commands](#advanced-dotnet-commands)
      - [1. Environment Information](#1-environment-information)
      - [2. Project and Solution Management](#2-project-and-solution-management)
      - [3. Dependency Management (NuGet Packages)](#3-dependency-management-nuget-packages)
      - [4. Publishing and Distribution](#4-publishing-and-distribution)
      - [5. Testing and Quality](#5-testing-and-quality)
      - [6. Scripts and Custom Tasks](#6-scripts-and-custom-tasks)
      - [7. Project Configuration](#7-project-configuration)
      - [8. `global.json` Configuration](#8-globaljson-configuration)
      - [9. Diagnostics](#9-diagnostics)
11. [Using `dotnet new` for Creating Projects](#using-dotnet-new-for-creating-projects)
12. [Complete Example](#complete-example)

---

## **Introduction to .NET CLI**
.NET CLI (`dotnet`) is the **command-line interface for .NET**, enabling **project creation, compilation, execution, package management, testing, and publishing**.

With **.NET Core 2.1**, released in **May 2018**, Microsoft introduced the .NET CLI (Command-Line Interface), offering developers **a lightweight and flexible way to create, build, run, and publish .NET applications** without relying solely on Visual Studio.

---

## Traditional .NET Development

Traditionally, to develop a .NET application, you would:
✔ Install **Visual Studio IDE**, which includes the **SDKs, build packages, and other dependencies**.  
✔ Use Visual Studio to **create, build, run, and publish** applications.  
✔ Rely on **Visual Studio's GUI**, even if you didn't need all of its features.

Visual Studio remains the **best IDE for C# and .NET development**, but **developers often prefer flexibility**.


---

## The Evolution .NET CLI
The **.NET CLI** is a powerful toolchain that allows you to:
✔ Develop **.NET applications** without Visual Studio.  
✔ Use **lightweight editors** like **VS Code**.  
✔ Execute **MSBuild, NuGet CLI, and other tasks** in one unified interface.  

With **.NET CLI**, you're no longer **bound to a single development tool**.

---

## **Main Features of .NET CLI**
✔ **Cross-platform compatibility** (Windows, Linux, macOS)  
✔ **Project initialization, build, and run support**  
✔ **Dependency and NuGet package management**  
✔ **Testing and deployment capabilities**  
✔ **CI/CD automation**  

---

## **Main `dotnet` Commands**

### **1. Project and Solution Initialization**
```sh
$ dotnet new console -n MyConsoleApp
$ dotnet new webapi -n MyAPI
$ dotnet new sln -n MySolution
```

### **2. Compilation and Execution**
```sh
$ dotnet build
$ dotnet run
```

### **3. Restoration of Dependencies**
```sh
$ dotnet restore
```

### **4. Package Management**
```sh
$ dotnet add package Newtonsoft.Json
$ dotnet remove package SomePackage
```

### **5. SDK and Runtime Information**
```sh
$ dotnet --version
$ dotnet --info
```

---

## **Basic Workflow with `dotnet`**
```sh
$ dotnet new console -n MyApp
$ cd MyApp
$ dotnet restore
$ dotnet build
$ dotnet run
```

---

## **Integration in CI/CD**
- Used in **GitHub Actions, Azure DevOps, Jenkins**.
- Automates **build, test, and deployment**.

---

## **Common `dotnet new` Templates**

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

---


### Console application (console) Genetic Algorithms.
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

### Class library (classlib) Matrix Operations

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
### web API (webapi) quantum physics.

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

### MVC (mvc) quantum physics concepts.

The project will simulate quantum states and provide interactive web interface for users to explore superposition and measurement operations.

```bash
dotnet new mvc -n QuantumMvc
dotnet new mvc -n LacanMvc
```


### xUnit (xunit) equilibrium constant
This project will implement and test functions for calculating the equilibrium constant (K) and reaction quotient (Q) in chemistry.

```bash
dotnet new classlib -n ChemistryLibrary
dotnet sln ChemistryXunitSolution.sln add ChemistryLibrary/ChemistryLibrary.csproj
dotnet new xunit -n ChemistryLibrary.Tests
dotnet sln ChemistryXunitSolution.sln add ChemistryLibrary.Tests/ChemistryLibrary.Tests.csproj
dotnet add ChemistryLibrary.Tests reference ChemistryLibrary/ChemistryLibrary.csproj
```

### MSTest to test Fourier Transform

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

### Worker Simulating Particle Decay

A background worker simulation radioactive decay of particles ov er time using probabilistic methods.

```bash
dotnet new worker -n ParticleDecayWorker
```

### Razor Pages Planck radiation law 

```bash
dotnet new razor -n BlackbodySpectrum
```

### Blazor Server time dilation

```bash
dotnet new blazorserver -n TimeDilationApp
```



---

## **Advantages of the .NET CLI**
✔ **Lightweight and fast**  
✔ **Cross-platform support**  
✔ **Easy automation and scripting**  
✔ **Efficient project management**  
✔ **Integration with DevOps**  

---

## **Advanced `dotnet` Commands**

### **1. Environment Information**
```sh
$ dotnet --list-sdks
$ dotnet --list-runtimes
```

### **2. Project and Solution Management**
```sh
$ dotnet sln add MyProject.csproj
$ dotnet sln remove MyProject.csproj
```

### **3. Dependency Management (NuGet Packages)**
```sh
$ dotnet nuget list source
$ dotnet nuget add source https://api.nuget.org/v3/index.json
```

### **4. Publishing and Distribution**
```sh
$ dotnet publish -c Release -o ./publish
```

### **5. Testing and Quality**
```sh
$ dotnet test
```

### **6. Scripts and Custom Tasks**
```sh
$ dotnet tool install -g dotnet-script
```

### **7. Project Configuration**
```sh
$ dotnet msbuild -property:Configuration=Release
```

### **8. `global.json` Configuration**
```sh
$ dotnet new globaljson --sdk-version 6.0.100
```

### **9. Diagnostics**
```sh
$ dotnet diagnostics collect
```

---

## **Using `dotnet new` for Creating Projects**
```sh
$ dotnet new console -n SampleApp
$ cd SampleApp
$ dotnet build
$ dotnet run
```

---

## **Complete Example**
```sh
$ dotnet new webapi -n MyWebAPI
$ cd MyWebAPI
$ dotnet add package Swashbuckle.AspNetCore
$ dotnet build
$ dotnet run
```

---

### **🚀 Final Thoughts**
- **The .NET CLI is a powerful tool** for .NET development.
- **It enables automation, scripting, and efficient project management.**
- **Mastering `dotnet` commands improves developer productivity and DevOps workflows.**

