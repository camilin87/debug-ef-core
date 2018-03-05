using Microsoft.EntityFrameworkCore;

namespace DebugEFCore
{
  public static class DbContextOptionsBuilderExtensions
  {
    public static void EnableLogging(this DbContextOptionsBuilder optionsBuilder, bool loggingEnabled = true)
    {
      if (loggingEnabled)
      {
        optionsBuilder.UseLoggerFactory(DataContextLoggerProvider.CreateFactory());
      }
    }
  }
}