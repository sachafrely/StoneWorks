// StoneWorks — GAME
// Role: Top-level application coordinator for startup, shutdown, and connecting runtime systems.
// Rules: Game coordinates systems but does not own domain gameplay rules.
// Dependencies: Core state/time plus the runtime systems that are explicitly created or connected here.
using Godot;

public partial class Game : Node
{
    public GameState State { get; private set; }
    public GameTime Time { get; private set; }
    public EventBus Events { get; private set; }

    public override void _Ready()
    {
        InitializeCore();
    }

    private void InitializeCore()
    {
        State = new GameState();

        Time = new GameTime();
        AddChild(Time);

        Events = new EventBus();
        AddChild(Events);
    }

    public override void _ExitTree()
    {
        State = null;
        Time = null;
        Events = null;
    }
}
