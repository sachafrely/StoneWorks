// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Central owner of runtime resources and resource creation/removal rules.
// Responsibilities: Create resources, register/remove them, find resources, track totals, and coordinate logical-to-physical creation.
// Rules: ResourceManager owns resource lifecycle; it does not decide market prices or worker movement.
// Dependencies: Resource, ResourceData, ResourceType, ResourceStack, ResourcePhysics, EventBus.
// Communication: Mining and machines request resource creation; logistics/storage request transfer/removal; physics handles physical representation.
// Planned functions: CreateResource(type, amount, position), RemoveResource(resource), GetResource(id), FindResources(type), GetTotal(type), Transfer(resource, destination), ClearTemporaryResources().
// Future considerations: Support pooled objects and aggregated resources to keep Android performance stable at high object counts.
