namespace EventAuto.Models;
public enum InteractionType
{
    Like,
    Dislike,
    Block,
    Report,
    Message,
    Match
}

public class UserInteractionObject
{
    public EventObject? Event { get; set; }
    public User Actor { get; set; } = null!;
    public User Target { get; set; } = null!;
    public InteractionType InteractionType { get; set; }
    public DateTime InteractionTime { get; set; }
    public UserInteractionObject(User actor, User target, InteractionType interactionType, EventObject? event_, DateTime interactionTime)
    {
        Actor = actor;
        Target = target;
        Event = event_;
        InteractionType = interactionType;
        InteractionTime = interactionTime;
    }
}

public class UserMatchObject
{
    public User User1 { get; set; } = null!;
    public User User2 { get; set; } = null!;
    public string MatchType { get; set; } = null!;
    public EventObject? Event { get; set; }

    public bool CurrentInteraction { get; set; }
    public bool IsMatched { get; set; }
    public UserMatchObject(User user1, User user2, string matchType, EventObject event_)
    {
        User1 = user1;
        User2 = user2;
        MatchType = matchType;
        Event = event_;
    }
}
