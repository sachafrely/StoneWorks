// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the collection and lifecycle of workers in the world.
// Responsibilities: Spawn/unlock workers, assign roles, register/remove workers, find available workers, and expose worker summaries.
// Rules: WorkerManager manages worker entities; it does not implement worker AI, movement, inventory, or job-selection rules.
// Dependencies: Worker, WorkerAI, WorkerJob, JobSystem, GameState, EventBus.
// Communication: UI requests role changes through WorkerManager; JobSystem requests available workers; unlock/progression announces new workers.
// Planned functions: CreateWorker(), RemoveWorker(worker), GetWorker(id), GetWorkers(), GetAvailableWorkers(role), AssignRole(worker, role), GetWorkerCounts().
// Future considerations: Enforce the global worker cap here and keep role assignment authoritative so UI cannot create invalid states.
