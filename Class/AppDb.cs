namespace Bhcirs.Class
{
    public class AppDb
    {
        public IConfiguration Configuration { get; }
        public string GetConnection() => Configuration.GetSection("ConnectionStrings").GetSection("dbConstring").Value;

        public AppDb(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}