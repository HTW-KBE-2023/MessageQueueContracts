namespace MessagingContracts.Survey
{
    public class VoteOnSurveyChanged
    {
        public Guid SurveyId { get; set; }

        public IList<(Guid OptionId, int change)> Changes { get; set; }
    }
}