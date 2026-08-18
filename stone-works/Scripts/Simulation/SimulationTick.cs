// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Defines one scheduled simulation update and its timing metadata.
// Responsibilities: Represent a tick interval, elapsed time, and which system/update category should run.
// Rules: SimulationTick is scheduling data; it should not implement the actual gameplay update.
// Dependencies: None or lightweight system identifiers.
// Communication: SimulationSystem creates/advances ticks and dispatches them to the appropriate systems.
// Planned functions: Advance(delta), IsDue(), Reset(), GetElapsed(), GetInterval(), MarkExecuted().
// Future considerations: Different systems may use different tick intervals to reduce Android CPU usage.
