using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Models
{
    public class UserRespondes : BasicItem
    {
        
        
        [Required(ErrorMessage = "Please enter your name  ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password ")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Please enter your email  ")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Please enter your phone  ")]
        public string PhoneNumber { get; set; }
        public DateTime dateTime { get; set; }
      
       
        





        public ICollection<DietPlan> dietPlans { get; set; }
        //public ICollection<TrainingPlan> traningPlans { get; set; }
        //public ICollection<UserLogIn> UserLogIn { get; set; }
        //public ICollection<TypeOfActivity> typeOfActivity { get; set; }
        //public ICollection<TypeOfFood> typeOfFood { get; set; }
        //public ICollection<Diseases> Diseases { get; set; }


    }
}
