namespace MessagingContracts.Survey
{
    public class VoteOnSurvey
    {
        private Guid ParticipantId { get; set; }
        private IEnumerable<Guid> OptionIds { get; set; }
    }
}