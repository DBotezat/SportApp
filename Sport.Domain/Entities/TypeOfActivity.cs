using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class TypeOfActivity : BasicItem
    {
        
        
        public string Type { get; set; }
        public int  DurationOfActivity { get; set; }    
        public int NumberOfTrainingsWeek { get; set; }  


    }
}