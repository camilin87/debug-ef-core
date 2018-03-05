using Microsoft.EntityFrameworkCore;

namespace store_scrapper_2.DAL.Db
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