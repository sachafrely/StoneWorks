// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates logistics work involving resources, machines, and storage.
// Responsibilities: Request transport jobs, prioritize deliveries, connect workers to storage/machine needs, and report logistics state.
// Rules: Logistics decides what should be transported; WorkerMovement decides how a worker physically moves.
// Dependencies: JobSystem, Storage, WorkerManager/WorkerAI, ResourceManager, EventBus.
// Communication: Creates transport requests when resources or machines require movement and reacts to completion events.
// Must not depend on: Rendering or direct manipulation of UI controls.
// Planned functions: RequestTransport(source, destination, resource), FindTransportTarget(resource), AssignTransportJob(), OnTransportCompleted(job), Update(delta).
// Future considerations: Support priorities, batching, carrying capacity, distance, and role restrictions.
