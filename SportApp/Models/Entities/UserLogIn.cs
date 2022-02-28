using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Models
{
    public class UserLogIn  
    {   
     
        public int Id { get; set; } 
        public string Login { get; set; }
        public string Password { get; set; }


       
        public UserRespondes UserName { get; set; }

    }
}
