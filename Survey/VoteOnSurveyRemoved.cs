namespace MessagingContracts.Survey
{
    public class VoteOnSurveyRemoved
    {
        public Guid SurveyId { get; set; }
        public Guid ParticipantId { get; set; }
        public Guid OptionId { get; set; }
    }
}