namespace MessagingContracts.Survey
{
    public class VoteOnSurveyAdded
    {
        public Guid SurveyId { get; set; }
        public Guid ParticipantId { get; set; }
        public Guid OptionId { get; set; }
    }
}