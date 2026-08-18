// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Authoritative game-clock and simulation-time service.
// Responsibilities: Track delta time, simulation speed, pause state, elapsed play time, and the timestamps needed for idle/offline progression.
// Rules: Provide time; do not decide how workers, machines, markets, or physics use that time.
// Dependencies: None on gameplay systems.
// Communication: SimulationSystem consumes time steps; systems may query current time or simulation speed.
// Must not depend on: UI, rendering, or individual gameplay entities.
// Planned functions: Advance(delta), SetSpeed(multiplier), Pause(), Resume(), GetDelta(), GetSimulationSpeed(), GetElapsedTime(), CalculateOfflineDuration().
// Future considerations: Keep real time and simulation time distinct so offline progression and speed-up features remain reliable.
