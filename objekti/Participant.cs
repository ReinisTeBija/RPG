using Godot;
using System;

public class Participant
{
    public string Name;
    public int Level = 1;
    private int energy;


# Konstruktors
    public Participant(string name, int energy)
    {
        Name = name;
        this.energy = energy;
        if (this.energy < 0) this.energy = 0;
    }

    public void ApplyPenalty(int amount)
    {
        if (amount < 0) return;
        energy -= amount;
        if (energy < 0) energy = 0;
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