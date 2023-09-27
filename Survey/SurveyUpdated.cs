namespace MessagingContracts.Survey
{
    public class SurveyUpdated
    {
        public Guid SurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public IList<Option> SurveyOptions { get; set; } = new List<Option>();
    }
}