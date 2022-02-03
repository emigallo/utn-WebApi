using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class CalculatorDbContext : BaseCalculatorDbContext
    {
        private CalculatorDbContext(DbContextOptions<BaseCalculatorDbContext> options) : base(options)
        {

        }

        public static CalculatorDbContext Build()
        {
            var options = new DbContextOptionsBuilder<BaseCalculatorDbContext>()
                .UseSqlServer(connectionString: "...")
                .Options;

            return new CalculatorDbContext(options);
        }
    }
}