using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class UserLogIn : BasicItem
    {   
     
    
        public string Login { get; set; }
        public string Password { get; set; }

        public UserRespondes UserResponde { get; set; }

    }
}
