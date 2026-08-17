// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Bridges logical Resource instances to their physical representation.
// Rules: A physical body is a representation of a resource, not the resource's authoritative identity/value. Keep implementation replaceable/optimizable.
// Dependencies: Resource, ResourceManager, PhysicsWorld, PhysicsBody.
// Communication: ResourceManager signals creation; ResourcePhysics asks PhysicsWorld to create/register the physical body.
// Must not depend on: UI, Economy, worker AI, or rendering ownership.
