using Sport.Domain.Entities.BasicItem;

namespace SportApp.Models
{
    public class Diseases : BasicItem
    { 
        public string NameOfDisease { get; set; }
        public List<Diseases> TypeofDiseases { get; set; }    

    }
}