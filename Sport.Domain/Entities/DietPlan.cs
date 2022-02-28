using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class DietPlan:BasicItem
    { 
       
        public string NameOfDiet { get; set; }
    
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        
        public int UserRespodesId { get; set; }
        public UserRespondes UserRespondes { get; set; }    
        
    }
}