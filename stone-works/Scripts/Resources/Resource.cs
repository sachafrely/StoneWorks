// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Logical resource instance: type, quantity/amount, quality, and logical state.
// Rules: A resource is gameplay data, not its physical body. Resource.cs must never own position, velocity, collision, or visual behavior.
// Dependencies: ResourceType and ResourceData.
// Communication: ResourceManager creates/registers resources; Physics.ResourcePhysics provides physical representation.
// Must not depend on: Physics implementation, UI, rendering, Economy, or worker behavior.
