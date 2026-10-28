using System;

public partial class Captain : Participant
{
    private int stability = 10;

    public Captain() : base()
    {
    }

    public Captain(string name) : base()
    {
        Setup(name, 150);
    }

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        base.ApplyPenalty(Math.Max(1, amount - stability));
    }
}