// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates pickup, delivery, machine-supply, warehouse, and gem-sorting logistics.
// Rules: Logistics creates/coordinates transport work; it does not directly control worker movement or invent worker behavior.
// Dependencies: JobSystem, TransportJob, Storage, Resource/Worker domain data, EventBus.
// Communication: Publishes available logistics work to JobSystem; workers execute accepted jobs through WorkerMovement/Inventory.
// Must not depend on: Economy pricing, UI presentation, or physics internals.
