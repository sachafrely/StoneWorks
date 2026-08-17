// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Chooses suitable work for a worker from available jobs.
// Rules: Selects based on role, priority, distance, carrying capacity, availability, and current situation. It does not create gameplay rules for the jobs.
// Dependencies: JobSystem, WorkerJob, Worker state, WorkerMovement/Inventory as needed for suitability.
// Communication: Requests/accepts jobs; delegates execution to the worker and relevant systems.
// Must not depend on: Economy or UI internals.
