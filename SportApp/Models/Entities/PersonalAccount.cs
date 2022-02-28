namespace SportApp.Models.Entities
{
    public class PersonalAccount 
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public TrainingPlan TraningPlan {get; set;}
        public DietPlan DietPlan { get; set; }  
    }
}
