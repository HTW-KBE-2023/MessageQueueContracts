namespace MessagingContracts.Survey
{
    public class SurveyOptionSelectionChanged
    {
        public Guid SurveyId { get; set; }

        public Guid SurveyOptionId { get; set; }
        public int TimesSelected { get; set; }
    }
}