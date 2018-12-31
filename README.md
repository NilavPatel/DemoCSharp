# DemoCSharp

## DemoMVC
`````
1. Login Page
2. Authentication Filter Attribute
3. Session to save login user details
4. CRUD operations for Employee
5. CRUD operations for Department

Technologies: MVC, Entity Framework, SQL server
`````

## DemoWCF, DemoWCFHost
`````
1. WCF service for Employee CRUD operations
2. Console Application for Hosting WCF application

Technologies: WCF, Entity Framework, SQL server
`````

## DemoDesignPatterns
`````
1. Factory Pattern with example of logger
2. Singlton Pattern with example of logger
3. Base Repository for sync and async entity framework CRUD operations

Technologies: C#, Design patterns
`````


## DemoWindowsService
`````
Sample for windows service and installer.

How to install windows services?

1. open cmd
2. run command (Run as administrator) below commands
    CD C:\Windows\Microsoft.NET\Framework\v4.0.30319
    installutil.exe "D:\4.Demo\DemoCSharp\DemoWindowsService\bin\Debug\DemoWindowsService.exe"
3. to uninstall service run below command
    installutil.exe /u "D:\4.Demo\DemoCSharp\DemoWindowsService\bin\Debug\DemoWindowsService.exe"
4. go to services.msc in start menu to see your installed service.
    find your service and start it, as this service is created to start manually.
    
Note: if cmd is not running with administrator privillage then, intstallutil will gives an exception.
`````

## Performance Testing
`````
Add sample project for performace testing for EF.
1. insert 10K records into local database.
2. retrive 10K records from local database.

statistics are as below:

DB: Microsoft SQL server (Local)
Asp.Net WebAPI hosted in local IIS

`````
![Image of PerformanceEF](https://github.com/NilavPatel/DemoCSharp/blob/master/PerformaceTestEF/Images/performanceEF.png)

## MVC PartialView sample

How to use partial views in MVC with single big Model class?