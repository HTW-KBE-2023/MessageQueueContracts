﻿namespace MessagingContracts.Survey
{
    public class SurveyCreated
    {
        public Guid SurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Option> SurveyOptions { get; set; } = new List<Option>();
    }
}