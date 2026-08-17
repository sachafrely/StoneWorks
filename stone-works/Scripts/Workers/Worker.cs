// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a worker entity and its minimal state.
// Rules: Keep workers relatively dumb. Worker does not contain mining, logistics, economy, machine, or market rules.
// Dependencies: WorkerJob, WorkerInventory, WorkerMovement; may receive commands from WorkerAI/Manager.
// Communication: Performs assigned actions through systems and emits domain events where appropriate.
// Must not depend on: Economy, Market, UI, or direct manipulation of other systems.
