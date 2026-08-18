// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Logical storage container for resources held by warehouses or other persistent storage locations.
// Responsibilities: Track capacities, add/remove resources, answer availability queries, and expose storage state.
// Rules: Storage owns stored quantities, not physical resource bodies. It should not move workers or decide market prices.
// Dependencies: ResourceType, ResourceStack, ResourceManager, GameState.
// Communication: Logistics deposits/withdraws resources; SellingSystem reads sellable stock; UI reads summaries.
// Must not depend on: WorkerMovement, physics visuals, or market implementation.
// Planned functions: Add(resource, amount), Remove(resourceType, amount), Has(resourceType, amount), GetAmount(resourceType), GetCapacity(), GetFreeCapacity(), CanStore(resource, amount).
// Future considerations: Support six gem warehouses plus general storage while keeping capacity rules centralized.
