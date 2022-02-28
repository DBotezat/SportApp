using Microsoft.EntityFrameworkCore;

namespace SportApp.Models
{
    public class DbInitializer 
    {
       
        public static void Initialize(MyContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
