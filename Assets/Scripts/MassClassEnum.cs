using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MassClassEnum
{
    public double mass { get; set; }
    public double radius { get; set; }
    public Color color { get; set; }
    public MassClassEnum.Planets type;

    public MassClassEnum(double mass)
    {
        this.mass = mass;
        type = DetectPlanet();
    }

    public enum Planets
    {
        Asteroidan,
        Mercurian,
        Subterran,
        Terran,
        Superterran,
        Neptunian,
        Jovian
    }

    private void SetParameters(double minrad, double maxrad, Color col, double minmass, double maxmass)
    {
        double percent = ((mass - minmass) * 100) / (maxmass - minmass);
        radius = (( minrad / 100) * percent + maxrad);
        color = col;
    }

    private Planets DetectPlanet()
    {
        switch (mass)
        {
            case double rangeMass when (rangeMass > 0 && rangeMass < 0.00001):
                SetParameters(0F, 0.03F, Color.blue, 0, 0.00001);
                return Planets.Asteroidan;
            case double rangeMass when (rangeMass > 0.00001 && rangeMass < 0.1):
                SetParameters(0.03F, 0.07F, Color.green, 0.00001, 0.1);
                return Planets.Mercurian;
            case double rangeMass when (rangeMass > 0.1 && rangeMass < 0.5):
                SetParameters(0.5F, 1.2F, Color.gray, 0.1, 0.5);
                return Planets.Subterran;
            case double rangeMass when (rangeMass > 0.5 && rangeMass < 2):
                SetParameters(0.8F, 1.9F, Color.cyan, 0.5, 2);
                return Planets.Terran;
            case double rangeMass when (rangeMass > 2 && rangeMass < 10):
                SetParameters(1.3F, 3.3F, Color.magenta, 2, 10);
                return Planets.Superterran;
            case double rangeMass when (rangeMass > 10 && rangeMass < 50):
                SetParameters(2.1F, 5.7F, Color.yellow, 10, 50);
                return Planets.Neptunian;
            case double rangeMass when (rangeMass > 50 && rangeMass < 5000):
                SetParameters(3.5F, 27F, Color.red, 50, 5000);
                return Planets.Jovian;
            default:
                throw new System.ComponentModel.InvalidEnumArgumentException(mass.ToString());
        }

        return 0;

    }
}
