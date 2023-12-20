namespace Employeewithef.Models
{
    public class DbContextOptions<T>
    {
        internal class UseSqlServer
        {
            private string v;

            public UseSqlServer(string v)
            {
                this.v = v;
            }

            public object Options { get; internal set; }
        }
    }
}