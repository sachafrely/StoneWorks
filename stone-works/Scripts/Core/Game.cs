// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Central application coordinator. Owns startup/shutdown and system initialization order.
// Responsibilities: Create or locate major systems, initialize them, load persistent state, and start/stop the simulation.
// Rules: Coordinate systems only. Do not contain mining, worker, machine, economy, physics, or UI gameplay rules.
// Dependencies: GameState, GameTime, EventBus, SimulationSystem, SaveSystem, World.
// Communication: Starts systems in a predictable order and lets systems communicate through their own interfaces/EventBus.
// Must not depend on: UI implementation details or individual entity internals.
// Planned functions: InitializeSystems(), LoadGame(), StartGame(), PauseGame(), ResumeGame(), ShutdownGame().
// Future considerations: Keep this class small; it should be possible to replace individual systems without rewriting Game.
