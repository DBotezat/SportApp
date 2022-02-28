using Sport.Domain.Entities.BasicItem;

namespace SportApp.Models
{
    public class Diseases 
    { 
        public int Id { get; set; } 
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        
        


        public UserRespondes UserName { get; set; }

    }
}