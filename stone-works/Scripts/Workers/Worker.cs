// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents one worker as a gameplay entity with role, assignment, inventory, movement state, and current job references.
// Responsibilities: Store worker identity/state and expose controlled operations for assignment, inventory, and job lifecycle.
// Rules: Worker is an entity, not a god object. Mining, logistics, pathfinding, and inventory rules belong to dedicated systems/components.
// Dependencies: WorkerJob, WorkerInventory, WorkerMovement, WorkerAI, JobSystem/WorkerManager interfaces.
// Communication: WorkerAI chooses work; WorkerMovement handles traversal; WorkerInventory handles carried resources; JobSystem provides jobs.
// Planned functions: AssignRole(role), SetJob(job), ClearJob(), GetRole(), GetJob(), GetInventory(), GetMovement(), IsAvailable().
// Future considerations: Keep the entity small so up to 20 workers can be simulated efficiently and so worker logic remains testable.
