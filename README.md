# try-dotnet-solution-2023

EFCoreTools
https://learn.microsoft.com/en-us/ef/core/get-started/overview/install

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer


dotnet new console -n FizzBuzz
dotnet new classlib -o MathOperationLibraries

dotnet new sln -n TrySolution
dotnet sln add FizzBuzz/FizzBuzz.csproj
dotnet sln add MathOperationLibraries/MathOperationLibraries.csproj
dotnet add MathOperationLibraries/MathOperationLibraries.csproj reference FizzBuzz/FizzBuzz.csproj
