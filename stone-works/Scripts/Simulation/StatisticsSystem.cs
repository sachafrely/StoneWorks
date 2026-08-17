// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Collects gameplay statistics for production, sales, workers, machines, resources, and progression.
// Rules: Observes system events/state; it must not become the owner of the gameplay values it measures.
// Dependencies: EventBus and read-only interfaces/data from relevant systems; GameTime for sampling cadence.
// Communication: Subscribes to events such as ResourceCreated, GemProduced, GemSold, WorkerUnlocked, and PrestigePerformed; UI reads prepared statistics.
// Must not depend on: UI implementation, rendering, or direct mutation of gameplay systems.
