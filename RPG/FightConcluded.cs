﻿namespace MessagingContracts.RPG;

public class FightConcluded
{
    public Guid FightId { get; set; }
    public Guid Player { get; set; }
    public IList<string>? Summary { get; set; }
}