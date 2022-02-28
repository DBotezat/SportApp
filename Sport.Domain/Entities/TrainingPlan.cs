using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class TrainingPlan : BasicItem
    {
     
        public string PlanName { get; set; } 
        public string TypeOfTraining { get; set; }
        public DateTime TimingOfTraining { get; set; } = DateTime.Now;
           
    }
}