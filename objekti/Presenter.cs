public partial class Presenter : Participant
{
    public Presenter() : base()
    {
    }

    public Presenter(string name) : base()
    {
        Setup(name, 80);
    }

    public override void ApplyPenalty(int amount)
    {
        if (amount <= 0) return;
        base.ApplyPenalty(amount + 5);
    }
}