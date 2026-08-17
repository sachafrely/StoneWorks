// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a quantity of a resource type in an inventory/storage context.
// Rules: Enforces quantity semantics; stacks are logical and do not represent individual physical pieces.
// Dependencies: ResourceType/ResourceData.
// Communication: Used by WorkerInventory, Storage, ResourceManager, and economy/processing systems.
// Must not depend on: Physics bodies, UI, worker movement, or market implementation.
