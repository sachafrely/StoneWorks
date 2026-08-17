// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns game-time semantics: delta time, simulation speed, pause state, and offline-time calculation.
// Rules: Provides time; does not directly update workers, machines, markets, or physics.
// Dependencies: GameState where time state is persisted; Godot clock/time source at implementation level.
// Communication: SimulationSystem consumes this time to schedule system updates.
// Must not depend on: UI or gameplay-specific systems.
