using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class TrainingPlan 
    {
        public int Id { get; set; } 
        public string PlanName { get; set; } 
        public string TypeOfTraining { get; set; }
        public DateTime TimingOfTraining { get; set; } = DateTime.Now;
        
        
        public UserRespondes UserRespondes { get; set; }
    }
}