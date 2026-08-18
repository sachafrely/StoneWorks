// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the simulation of physical bodies and their interactions.
// Responsibilities: Advance physics, apply gravity, detect/resolves collisions, handle ground contact, and put resting objects to sleep.
// Rules: PhysicsWorld owns physical behavior; it does not decide what resources are worth or where workers should transport them.
// Dependencies: PhysicsBody, World/Terrain collision data, GameTime, EventBus.
// Communication: ResourcePhysics registers bodies; world collision data supplies terrain boundaries; gameplay systems receive physical state/events when needed.
// Planned functions: AddBody(body), RemoveBody(body), Step(delta), DetectCollisions(), ResolveCollisions(), ApplyGravity(), UpdateSleepingBodies().
// Future considerations: Do not assume one full Godot rigid-body node per resource; the architecture should support optimized batching/spatial partitioning for hundreds or thousands of objects.
