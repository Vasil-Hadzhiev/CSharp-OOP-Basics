﻿namespace NeedForSpeed.Factories
{
    using NeedForSpeed.Models.Races;

    public class RaceFactory
    {
        public Race CreateRace(string type, int length, string route, int prizePool)
        {
            switch (type)
            {
                case "Casual":
                    return new CasualRace(length, route, prizePool);
                case "Drag":
                    return new DragRace(length, route, prizePool);
                case "Drift":
                    return new DriftRace(length, route, prizePool);
                default:
                    return null;
            }
        }
    }
}