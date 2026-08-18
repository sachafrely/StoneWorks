// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays worker counts, roles, assignments, and worker-management controls.
// Responsibilities: Show Mining vs Logistics workers, allow role reassignment, and display worker/job status.
// Rules: WorkerUI sends high-level assignment commands; it must not modify WorkerAI, WorkerMovement, or WorkerInventory internals.
// Dependencies: WorkerManager/JobSystem command/read interfaces, GameState, EventBus.
// Communication: Requests role changes and reacts to WorkerUnlocked, WorkerAssigned, JobChanged, and related events.
// Planned functions: RefreshWorkerCounts(), RefreshWorkerList(), HandleAssignMining(), HandleAssignLogistics(), ShowWorkerStatus(), OnWorkerChanged().
// Future considerations: The design currently starts with two workers and a planned maximum of 20; keep the UI scalable for future worker counts.
