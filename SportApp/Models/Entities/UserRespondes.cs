using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Models
{
    public class UserRespondes 
    { 
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name  ")]
        public string UserName { get; set; }
       
        [EmailAddress(ErrorMessage = "Please enter your email  ")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Please enter your phone  ")]
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
      

        
        public int UserLogInId { get; set; }    
        public virtual UserLogIn UserLogIn { get; set; }

        public int DietPlanId { get; set; }
        public DietPlan DietPlan { get; set; }  
       
        public int TrainingPlanId { get; set; } 
        public TrainingPlan TrainingPlan { get; set; }
        

        public int DiseasesId { get; set; }
        public Diseases Diseases { get; set; }  


        public int TypeOfActivityId { get; set; }
        public TypeOfActivity   TypeOfActivity { get; set; }    


        public int TypeOfFoodId { get; set; }
        public TypeOfFood TypeOfFood { get; set; }  
        
        //public ICollection<DietPlan> dietPlans { get; set; }
        //public ICollection<TrainingPlan> traningPlans { get; set; }
       
        //public ICollection<TypeOfActivity> typeOfActivity { get; set; }
        //public ICollection<TypeOfFood> typeOfFood { get; set; }
        //public ICollection<Diseases> Diseases { get; set; }


    }
}
