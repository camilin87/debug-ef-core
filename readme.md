# Debug Entity Framework Code  

Nuget to debug the SQL statements [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) is executing.  

Entity Framework has a convenient way to [log the SQL statements it executes](https://blogs.msdn.microsoft.com/mpeder/2014/06/16/how-to-see-the-actual-sql-query-generated-by-entity-framework/). Unfortunately this functionality is not available out-of-the-box for Entity Framework Core. [Entity Framework Core Issue #6482](https://github.com/aspnet/EntityFrameworkCore/issues/6482) captures this need.  

## Usage  

```csharp
using DebugEFCore;

public class SampleContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    var debugLoggingEnabled = true;
    optionsBuilder.EnableLogging(debugLoggingEnabled);
  }
}
```

## Installation  

Follow the steps from the [`DebugEFCore` Nuget Package](https://www.nuget.org/packages/DebugEFCore/).  

## Dependencies  

- [Log4Net](https://www.nuget.org/packages/log4net/)  
- [EntifyFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)  
- [Microsoft.Extensions.Logging](https://www.nuget.org/packages/Microsoft.Extensions.Logging)  

## License  

[MIT](https://github.com/angular/angular.js/blob/master/LICENSE)  
