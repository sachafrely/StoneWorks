// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a resource transportation task from source to destination.
// Rules: Contains source, destination, resource, quantity, priority, and state; does not move the worker itself.
// Dependencies: Resource/ResourceStack, Storage/source-destination data, WorkerJob.
// Communication: JobSystem exposes it; WorkerAI selects it; WorkerMovement and WorkerInventory execute it.
// Must not depend on: Economy, UI, physics internals, or direct worker movement implementation.
