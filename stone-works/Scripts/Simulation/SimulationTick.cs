// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents one simulation update/tick and the timing context passed to systems.
// Rules: Carries timing information; does not itself execute gameplay rules.
// Dependencies: GameTime and simulation scheduling data.
// Communication: SimulationSystem creates/provides ticks to systems according to their update cadence.
// Must not depend on: UI, Economy implementation, or concrete entity behavior.
