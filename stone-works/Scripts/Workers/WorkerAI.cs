// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Chooses what an available worker should do and coordinates execution of the worker's current job.
// Responsibilities: Evaluate job options, accept/cancel jobs, transition worker states, and request movement/actions from dedicated components.
// Rules: WorkerAI decides intent; it does not implement pathfinding, inventory storage, mining rules, or machine processing.
// Dependencies: Worker, JobSystem, WorkerJob, WorkerMovement, WorkerInventory, EventBus.
// Communication: Requests jobs from JobSystem, commands WorkerMovement, and reacts to job/resource/world events.
// Planned functions: FindJob(), EvaluateJob(job), AcceptJob(job), CancelJob(), Update(delta), ExecuteCurrentJob(), HandleJobCompleted(), HandleJobFailed().
// Future considerations: Include role restrictions, distance, priority, carrying capacity, and current worker state in job selection.
