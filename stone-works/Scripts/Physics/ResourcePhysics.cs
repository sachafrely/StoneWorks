// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Connects logical resources with their physical representation in the world.
// Responsibilities: Create/remove physical bodies for resources, configure physical properties, and synchronize logical and physical state.
// Rules: A resource can exist logically without being simulated physically; ResourcePhysics owns the bridge, not the resource's economy/storage rules.
// Dependencies: Resource, PhysicsWorld, PhysicsBody, World/Terrain collision data.
// Communication: ResourceManager requests physical creation; PhysicsWorld advances bodies; Resource events notify interested systems.
// Planned functions: CreatePhysicalResource(resource, position), RemovePhysicalResource(resource), ConfigureBody(resource, body), SyncLogicalState(), DespawnIfOutOfBounds().
// Future considerations: Support different mass/friction/bounce for stones and gems and an optimized sleeping/resting representation.
