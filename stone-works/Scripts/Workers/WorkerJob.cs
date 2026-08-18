// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Data representation of one task assigned to a worker.
// Responsibilities: Store job type, target, priority, assignment, lifecycle state, and completion/failure information.
// Rules: WorkerJob contains job state; JobSystem owns the global job queue and WorkerAI owns decision-making.
// Dependencies: Job identifiers/types, worker identity, optional target references.
// Communication: JobSystem creates/reserves jobs; WorkerAI executes them; systems receive completion/failure events.
// Planned functions: Assign(worker), Unassign(), Start(), Complete(), Fail(reason), Cancel(), IsAvailable(), IsComplete(), GetPriority(), GetTarget().
// Future considerations: Use a common job contract so MiningJob and TransportJob can be handled consistently.
