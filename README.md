# Open-Api Generated .NET Core Web Api

## Folder Structure

```
.
└── <YOUR_API>_folder
    ├── README.md
    ├── <YOUR_API>.sln
    |
    ├── build
    │   ├── build.sh
    │   └── build.ps1
    |
    ├── spec
    │   └── swagger.json
    |
    ├── src
    │   └── <YOUR_API>
    |       ├── <YOUR_API>.csproj
    │       ├── implementation
    │       │   └── ControllerDelegateImpl.cs
    |       └── generated
    |           ├── ControllerInterface.cs
    |           └── ControllerDelegate.cs 
    |
    └── test
        ├── <YOUR_API>.IntegrationTests
        │   ├── ActuatorsTests.cs
        │   └── <YOUR_API>.IntegrationTests.csproj   
        └── <YOUR_API>.UnitTests
            └── <YOUR_API>.UnitTests.csproj
```

## intro for folder structure

## next steps to start development

## build and publish

## scoped logging & enriching with SeriLog

https://github.com/serilog/serilog-aspnetcore 
https://github.com/serilog/serilog-formatting-compact 



```c#
using (_logger.BeginScope("TransctionId:{transctionId}", new Random().Next(1, 5)))
                _logger.LogInformation("returning values");
```