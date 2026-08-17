// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Small temporary inventory carried by a worker.
// Rules: Enforces carrying capacity and resource stack changes; does not own warehouse storage or selling rules.
// Dependencies: Resource, ResourceStack, ResourceType; Worker owns/uses this inventory.
// Communication: Logistics uses inventory state during pickup/delivery; resource events may be emitted after successful transfers.
// Must not depend on: Economy, UI, or physics internals.
