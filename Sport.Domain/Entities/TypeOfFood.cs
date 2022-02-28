using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class TypeOfFood : BasicItem
    {
        
        
        public string typeOfFood { get; set; }
        public int CountOfFoodPerDay { get; set; }
        public float CountOfKcal { get; set; }  



    }
}