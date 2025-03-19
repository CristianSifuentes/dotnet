# **.NET CLI (dotnet) - Comprehensive Guide**

## **Table of Contents**
1. [Introduction to .NET CLI](#introduction-to-net-cli)
2. [Main Features of .NET CLI](#main-features-of-net-cli)
3. [Main `dotnet` Commands](#main-dotnet-commands)
   - [1. Project and Solution Initialization](#1-project-and-solution-initialization)
   - [2. Compilation and Execution](#2-compilation-and-execution)
   - [3. Restoration of Dependencies](#3-restoration-of-dependencies)
   - [4. Package Management](#4-package-management)
   - [5. SDK and Runtime Information](#5-sdk-and-runtime-information)
4. [Basic Workflow with `dotnet`](#basic-workflow-with-dotnet)
5. [Integration in CI/CD](#integration-in-cicd)
6. [Common `dotnet new` Templates](#common-dotnet-new-templates)
7. [Advantages of the .NET CLI](#advantages-of-the-net-cli)
8. [Advanced `dotnet` Commands](#advanced-dotnet-commands)
   - [1. Environment Information](#1-environment-information)
   - [2. Project and Solution Management](#2-project-and-solution-management)
   - [3. Dependency Management (NuGet Packages)](#3-dependency-management-nuget-packages)
   - [4. Publishing and Distribution](#4-publishing-and-distribution)
   - [5. Testing and Quality](#5-testing-and-quality)
   - [6. Scripts and Custom Tasks](#6-scripts-and-custom-tasks)
   - [7. Project Configuration](#7-project-configuration)
   - [8. `global.json` Configuration](#8-globaljson-configuration)
   - [9. Diagnostics](#9-diagnostics)
9. [Using `dotnet new` for Creating Projects](#using-dotnet-new-for-creating-projects)
10. [Complete Example](#complete-example)

---

## **Introduction to .NET CLI**
.NET CLI (`dotnet`) is the **command-line interface for .NET**, enabling **project creation, compilation, execution, package management, testing, and publishing**.

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
| Template | Command |
|----------|---------|
| Console App | `dotnet new console` |
| Web API | `dotnet new webapi` |
| Class Library | `dotnet new classlib` |
| MVC | `dotnet new mvc` |
| Blazor Server | `dotnet new blazorserver` |
| Blazor WebAssembly | `dotnet new blazorwasm` |

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

