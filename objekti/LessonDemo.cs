using Godot;
using System.Collections.Generic;

public partial class LessonDemo : Node
{
    public override void _Ready()
    {
        List<Participant> party = new List<Participant>();
        Participant dominiks = new Participant();
        dominiks.Setup("Dominiks", 100);
        party.Add(dominiks);
        party.Add(new Captain("Anna"));
        party.Add(new Presenter("Jānis"));

        foreach (Participant p in party)
        {
            int before = p.GetEnergy();
            p.ApplyPenalty(20);
            GD.Print(p.ParticipantName, ": ", before, " -> ", p.GetEnergy());
        }
    }
}