// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Serializable representation of game state that must survive save/load.
// Rules: Contains data, not gameplay behavior. Explicitly distinguish persistent progression from resettable run state for prestige.
// Dependencies: Serializable projections of GameState, Resource/Worker/Machine/World/Economy/Progression state as required.
// Communication: SaveSystem builds/restores SaveData; systems consume restored state during initialization.
// Must not depend on: Godot scene nodes, UI, physics bodies, or transient runtime-only objects.
