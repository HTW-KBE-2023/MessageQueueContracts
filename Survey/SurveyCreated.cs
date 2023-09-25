namespace MessagingContracts.Survey
{
    public class SurveyCreated
    {
        public Guid SurveyId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IList<SurveyOption> SurveyOptions { get; set; } = new List<SurveyOption>();

        public class SurveyOption
        {
            public Guid SurveyOptionId { get; set; }
            public string? Text { get; set; }
            public int Position { get; set; }
            public int TimesSelected { get; set; }
        }
    }
}