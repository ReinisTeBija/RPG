using Godot;

public partial class StatsDemo : Node
{
    public override void _Ready()
    {
        Participant anna = new Participant();
        AddChild(anna);
        anna.Setup("Anna", 100);
        anna.ApplyPenalty(30);
        anna.Heal(50);
        GD.Print("Enerģija: ", anna.GetEnergy());

        Stats copy = anna.GetStats();
        copy.Energy = 1;
        GD.Print("Kopija: ", copy.Energy, "; Anna: ", anna.GetEnergy());

        anna.AddBuff(new Buff { Name = "Atbalsts", FocusBonus = 5 });
        anna.AddBuff(new Buff { Name = "Atpūta", FocusBonus = 3 });
        GD.Print("Fokuss ar diviem bonusiem: ", anna.GetTotalFocus());
        anna.RemoveBuffAt(0);
        GD.Print("Fokuss pēc pirmā noņemšanas: ", anna.GetTotalFocus());
    }
}