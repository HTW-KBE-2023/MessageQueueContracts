namespace MessagingContracts.Survey
{
    public class Option
    {
        public Guid SurveyOptionId { get; set; }
        public string? Text { get; set; }
        public int Position { get; set; }
        public int TimesSelected { get; set; }
    }
}