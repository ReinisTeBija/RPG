using Godot;
using System;

public partial class LessonDemo : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Participant Anna = new Participant("Anna", 100);
		Participant Janis = new Participant("Jānis", 80);
		Anna.ApplyPenalty(30);
		GD.Print(Anna.Name, ": ", Anna.GetEnergy());
		GD.Print(Janis.Name, ": ", Janis.GetEnergy());
		Anna.ApplyPenalty(100);
		GD.Print("Anna: ", Anna.GetEnergy(), "Aktīva: ", Anna.IsActive());


	}
}
