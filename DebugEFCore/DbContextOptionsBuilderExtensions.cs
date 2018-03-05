using Microsoft.EntityFrameworkCore;

namespace DebugEFCore
{
  public static class DbContextOptionsBuilderExtensions
  {
    public static void ConfigureLogging(this DbContextOptionsBuilder optionsBuilder, bool loggingEnabled)
    {
      if (loggingEnabled)
      {
        optionsBuilder.UseLoggerFactory(DataContextLoggerProvider.CreateFactory());
      }
    }
  }
}