﻿namespace _03_Ferrari
{
    public interface ICar
    {
        string Model { get; }

        string Driver { get; }

        string PushBrakes();

        string PushGasPedal();
    }
}
