// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a planned or active mining task assigned to a worker.
// Responsibilities: Store target area, mining action, priority, assigned worker, and completion state.
// Rules: MiningJob describes work; MiningSystem owns the rules for whether and how mining occurs.
// Dependencies: Mine/WorldGrid, Worker role data, Dynamite/resource data.
// Communication: JobSystem offers jobs; WorkerAI accepts them; MiningSystem executes the mining operation.
// Planned functions: CanExecute(), Reserve(worker), GetTarget(), GetPriority(), MarkStarted(), MarkComplete(), Cancel(reason).
// Future considerations: Support different mine depths, mining priorities, explosive types, and randomized explosion patterns.
