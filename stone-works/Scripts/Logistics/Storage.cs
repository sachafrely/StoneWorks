// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents inventory/storage behavior for warehouses and other storage locations.
// Rules: Owns persistent stored resource quantities and capacity/sorting constraints; physical loose resources are separate until transferred/stored.
// Dependencies: ResourceStack, ResourceType, ResourceManager; may integrate with World/Warehouse state.
// Communication: Logistics transfers resources into/out of Storage; ResourceDelivered/Stored events may notify statistics/UI.
// Must not depend on: Worker AI, Economy pricing, or UI internals.
