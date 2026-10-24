using Godot;
using System;

public partial class Participant : Node
{
    [Signal]
    public delegate void FinishedEventHandler(string participantName);

    public string ParticipantName = "Dalībnieks";
    private int energy = 100;

    public Participant()
    {
        ParticipantName = "Dalībnieks";
        energy = 100;
    }

    public Participant(string name, int initialEnergy)
    {
        ParticipantName = name;
        energy = Math.Max(0, initialEnergy);
    }

    public void Setup(string name, int initialEnergy)
    {
        ParticipantName = name;
        energy = Math.Max(0, initialEnergy);
    }

    public virtual void ApplyPenalty(int amount)
    {
        if (!IsActive() || amount <= 0) return;
        energy = Math.Max(0, energy - amount);
        if (energy == 0)
            EmitSignal(SignalName.Finished, ParticipantName);
    }

    public int GetEnergy()
    {
        return energy;
    }

    public bool IsActive()
    {
        return energy > 0;
    }
}