// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Coordinates creation, registration, lookup, and logical lifecycle of resources.
// Rules: Owns logical resource state only; physical bodies are delegated to PhysicsWorld/ResourcePhysics.
// Dependencies: Resource, ResourceData, ResourceType, EventBus; PhysicsWorld/ResourcePhysics through a clear boundary when spawning physical resources.
// Communication: Mining and machines request resource creation; logistics/storage consume resources; emits ResourceCreated and related events.
// Must not depend on: UI or rendering logic.
