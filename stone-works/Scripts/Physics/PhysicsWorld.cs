// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns physical simulation: gravity, collision detection/resolution, ground/resource collisions, sleeping/resting, and physics updates.
// Rules: Physics owns physical state; gameplay systems request creation/changes through boundaries. Avoid one full rigid body per resource if scale makes Android performance poor.
// Dependencies: PhysicsBody, GameTime/SimulationSystem, World/Terrain collision data, ResourcePhysics.
// Communication: ResourceManager creates logical resources; ResourcePhysics creates/registers bodies; PhysicsWorld advances them and reports relevant events.
// Must not depend on: Economy, UI, WorkerAI, or market logic.
