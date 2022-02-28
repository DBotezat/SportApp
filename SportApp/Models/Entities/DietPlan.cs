using Sport.Domain.Entities.BasicItem;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public class DietPlan
    {
        public int Id { get; set; }
        public string NameOfDiet { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }


        public UserRespondes UserName { get; set; }

    }
}