using Godot;
using System;
using System.Collections.Generic;

public partial class Participant : Node
{
    [Signal]
    public delegate void FinishedEventHandler(string participantName);

    public string ParticipantName = "Dalībnieks";
    private Stats stats = new Stats(100, 10);
    private List<Buff> buffs = new List<Buff>();

    public void Setup(string name, int initialEnergy)
    {
        ParticipantName = name;
        stats = new Stats(Math.Max(0, initialEnergy), 10);
        buffs.Clear();
    }

    public virtual void ApplyPenalty(int amount)
    {
        if (!IsActive() || amount <= 0) return;
        stats.Energy = Math.Max(0, stats.Energy - amount);
        if (stats.Energy == 0)
            EmitSignal(SignalName.Finished, ParticipantName);
    }

    public int GetEnergy()
    {
        return stats.Energy;
    }

    public bool IsActive()
    {
        return stats.Energy > 0;
    }

    public Stats GetStats()
    {
        return stats;
    }

    public void Heal(int amount)
    {
        if (IsActive()) stats.Heal(amount);
    }

    public void AddBuff(Buff buff)
    {
        buffs.Add(buff);
    }

    public void RemoveBuffAt(int index)
    {
        buffs.RemoveAt(index);
    }

    public int GetTotalFocus()
    {
        int total = stats.Focus;
        foreach (Buff buff in buffs)
        {
            total += buff.FocusBonus;
        }
        return total;
    }
}