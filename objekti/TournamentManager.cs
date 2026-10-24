using Godot;

public partial class TournamentManager : Node
{
    public override void _Ready()
    {
        Participant anna = GetNode<Participant>("Anna");
        Participant janis = GetNode<Participant>("Janis");
        anna.Setup("Anna", 150);
        janis.Setup("Jānis", 80);

        anna.Finished += OnParticipantFinished;
        janis.Finished += OnParticipantFinished;

        anna.ApplyPenalty(10);  // Paliek 20. Signāla vēl nav.
        anna.ApplyPenalty(20);  // Anna izstājas.
        anna.ApplyPenalty(5);   // Atkārtots paziņojums nerodas.
        janis.ApplyPenalty(20); // Jānis izstājas.
    }

    private void OnParticipantFinished(string participantName)
    {
        GD.Print(participantName, " izstājās");
    }
}