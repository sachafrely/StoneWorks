// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Central application coordinator. Owns startup/shutdown and system initialization order.
// Rules: Coordinates systems only; does not contain mining, worker, machine, economy, physics, or UI gameplay rules.
// Dependencies: GameState, GameTime, EventBus, SimulationSystem, SaveSystem, World.
// Communication: Initializes systems and starts simulation; gameplay systems communicate through their own boundaries/EventBus.
// Must not depend on: UI implementation details or individual entity internals.
