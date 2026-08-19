// StoneWorks — GAME STATE
// Role: Persistent gameplay state container used at save/load boundaries.
// Rules: Stores state but does not perform gameplay rules or coordinate systems.
// Dependencies: Serializable gameplay state types only.
using Godot;

public partial class GameState : Resource
{
    [Export]
    public int SaveVersion { get; set; } = 1;

    public void ResetToDefaults()
    {
        SaveVersion = 1;
    }
}
