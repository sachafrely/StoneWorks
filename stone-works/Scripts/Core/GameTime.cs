// StoneWorks — GAME TIME
// Role: Owns the simulation clock, pause/speed state, and time information needed for offline progression calculations.
// Rules: Provides time state; it does not advance domain gameplay rules itself.
// Dependencies: Godot/application time source and explicit simulation-time consumers.
using Godot;
using System;

public partial class GameTime : Node
{
    public bool IsPaused { get; private set; }
    public double TimeScale { get; private set; } = 1.0;
    public double TotalRealTime { get; private set; }
    public double TotalGameTime { get; private set; }
    public double LastDelta { get; private set; }

    public override void _Process(double delta)
    {
        LastDelta = delta;
        TotalRealTime += delta;

        if (!IsPaused)
        {
            TotalGameTime += delta * TimeScale;
        }
    }

    public void SetPaused(bool paused)
    {
        IsPaused = paused;
    }

    public void SetTimeScale(double timeScale)
    {
        TimeScale = Math.Max(0.0, timeScale);
    }

    public void Reset()
    {
        TotalRealTime = 0.0;
        TotalGameTime = 0.0;
        LastDelta = 0.0;
        IsPaused = false;
        TimeScale = 1.0;
    }
}
